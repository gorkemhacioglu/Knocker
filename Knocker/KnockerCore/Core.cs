using KnockerCore.DTO;
using KnockerCore.Helper;
using log4net;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using static KnockerCore.Helper.Factory;

namespace KnockerCore
{
    public class Core
    {
        ConcurrentBag<Tuple<IPAddress, int>> _addresses = new ConcurrentBag<Tuple<IPAddress, int>>();

        ConcurrentQueue<Thread> _runningThreads = new ConcurrentQueue<Thread>();

        private static readonly ILog _log = LogManager.GetLogger("Knocker");

        CancellationToken mainCancellationToken;

        public volatile int limitation;

        public volatile int totalCalculatedAddresses;

        public volatile int scannedAddresses;

        public bool StartScanning(string hostStart, string hostStop, int portStart, int portStop, int limit, CancellationToken token)
        {
            try
            {
                _log.Info("Core Started");
                totalCalculatedAddresses = 0;
                scannedAddresses = 0;
                limitation = limit;
                mainCancellationToken = token;
                _addresses.Clear();
                _runningThreads.Clear();
                Broadcaster().Broadcast(typeof(MainStatusDto).ToString(), new MainStatusDto { IsRunning = true, RunningThreadCount = _runningThreads.Count() });

                Task.Run(() =>
                {
                    var startArr = hostStart.Split('.').Select(Byte.Parse).ToArray();
                    var endArr = hostStop.Split('.').Select(Byte.Parse).ToArray();

                    var start = BitConverter.ToInt32(new byte[] { startArr[3], startArr[2], startArr[1], startArr[0] }, 0);
                    var end = BitConverter.ToInt32(new byte[] { endArr[3], endArr[2], endArr[1], endArr[0] }, 0);

                    for (int i = start; i <= end; i++)
                    {
                        if (token.IsCancellationRequested)
                            break;

                        byte[] bytes = BitConverter.GetBytes(i);
                        for (int j = portStart; j <= portStop; j++)
                        {
                            _addresses.Add(Tuple.Create(new IPAddress(new[] { bytes[3], bytes[2], bytes[1], bytes[0] }), j));
                            Interlocked.Increment(ref totalCalculatedAddresses);
                        }
                    }
                }, token);

                Thread.Sleep(1000);

                Task.Run(() =>
                {
                    while (true)
                    {
                        Broadcaster().Broadcast(typeof(MainStatusDto).ToString(), new MainStatusDto { IsRunning = true, RunningThreadCount = _runningThreads.Count(), TotalCalculatedAddresses = totalCalculatedAddresses, ScannedAddresses = scannedAddresses });
                        Thread.Sleep(10);
                        if (token.IsCancellationRequested)
                            break;
                    }
                }, token);

                while (true)
                {
                    if (token.IsCancellationRequested)
                    {
                        token.ThrowIfCancellationRequested();
                    }

                    if (_addresses.IsEmpty && _runningThreads.IsEmpty)
                        break;
                    else if (!_addresses.IsEmpty && _runningThreads.Count < limitation)
                    {
                        Thread thr = new Thread(() => StartTakingFromBag());
                        thr.SetApartmentState(ApartmentState.MTA);
                        thr.Start();
                        _runningThreads.Enqueue(thr);
                    }

                    Thread temp;
                    bool gotIt = _runningThreads.TryDequeue(out temp);

                    if (gotIt)
                    {
                        if (temp.IsAlive)
                            _runningThreads.Enqueue(temp);
                    }
                }

                Broadcaster().Broadcast(typeof(MainStatusDto).ToString(), new MainStatusDto { IsRunning = false, RunningThreadCount = _runningThreads.Count(), IsCompleted = true, TotalCalculatedAddresses = totalCalculatedAddresses, ScannedAddresses = scannedAddresses });
                return true;
            }
            catch (Exception ex)
            {
                _log.Error(ex);
                Broadcaster().Broadcast(typeof(MainStatusDto).ToString(), new MainStatusDto { IsRunning = false, RunningThreadCount = 0, IsCompleted = false, TotalCalculatedAddresses = totalCalculatedAddresses, ScannedAddresses = scannedAddresses });
                return false;
            }
        }

        public void UpdateLimitation(int limit)
        {
            limitation = limit;
        }
        public void StartTakingFromBag()
        {
            Tuple<IPAddress, int> item;
            var a = _addresses.TryTake(out item);
            if (!a)
                return;
            else
            {
                IsPortOpen(item.Item1.ToString(), item.Item2);
            }

        }

        public bool IsPortOpen(string ipaddress, int port)
        {
            using (var tcpClient = new TcpClient())
            {
                try
                {
                    var result = tcpClient.BeginConnect(ipaddress, port, null, null);
                    tcpClient.EndConnect(result);

                    var threadStatusDto = new ThreadStatusDto
                        {Id = Thread.CurrentThread.ManagedThreadId, IpAddress = ipaddress, Port = port.ToString()};
                        
                    IPAddress.TryParse(ipaddress, out var ip);
                    if (ip != null)
                    {
                        threadStatusDto.MacAddress = GetMacAddress(ip);
                    }

                    Thread thr = new Thread(() => Broadcaster().Broadcast(typeof(ThreadStatusDto).ToString(), threadStatusDto));
                    thr.Start();
                }
                catch (Exception)
                {
                    Interlocked.Increment(ref scannedAddresses);
                    return false;
                }
                Interlocked.Increment(ref scannedAddresses);
                return true;
            }
        }
        
        [DllImport("iphlpapi.dll", ExactSpelling = true)]
        private static extern int SendARP(uint destIp, uint srcIp, byte[] macAddress, ref uint macAddressLength);
        
        private static string GetMacAddress(IPAddress address)
        {
            byte[] mac = new byte[6];
            uint len = (uint)mac.Length;
            byte[] addressBytes = address.GetAddressBytes();
            uint dest = ((uint)addressBytes[3] << 24)
                        + ((uint)addressBytes[2] << 16)
                        + ((uint)addressBytes[1] << 8)
                        + ((uint)addressBytes[0]);
            if (SendARP(dest, 0, mac, ref len) != 0)
            {
                return "N/A";
            }
            return   BitConverter.ToString(mac);
        }
    }
}
