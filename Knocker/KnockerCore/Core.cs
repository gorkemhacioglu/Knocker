using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace KnockerCore
{
    public class Core
    {
        ConcurrentBag<Tuple<IPAddress, int>> _addresses = new ConcurrentBag<Tuple<IPAddress, int>>();

        ConcurrentBag<Thread> _runningThreads = new ConcurrentBag<Thread>();

        public bool StartScanning(string hostStart, string hostStop, int portStart, int portStop)
        {
            try
            {
                _addresses.Clear();

                //Task.Run(() =>
                //{
                var startArr = hostStart.Split('.').Select(Byte.Parse).ToArray();
                var endArr = hostStop.Split('.').Select(Byte.Parse).ToArray();

                var start = BitConverter.ToInt32(new byte[] { startArr[3], startArr[2], startArr[1], startArr[0] }, 0);
                var end = BitConverter.ToInt32(new byte[] { endArr[3], endArr[2], endArr[1], endArr[0] }, 0);

                for (int i = start; i <= end; i++)
                {
                    byte[] bytes = BitConverter.GetBytes(i);
                    for (int j = portStart; j <= portStop; j++)
                    {
                        _addresses.Add(Tuple.Create(new IPAddress(new[] { bytes[3], bytes[2], bytes[1], bytes[0] }), j));
                    }
                }
                //});

                while (true)
                {
                    if (_addresses.IsEmpty && _runningThreads.IsEmpty)
                        break;
                    else if (!_addresses.IsEmpty && _runningThreads.Count < 500)
                    {
                        Thread thr = new Thread(() => StartTakingFromBag());
                        _runningThreads.Add(thr);
                        thr.Start();
                    }

                    Thread temp;
                    bool gotIt = _runningThreads.TryTake(out temp);

                    if (gotIt)
                    {
                        if (temp.IsAlive)
                            _runningThreads.Add(temp);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        void StartTakingFromBag()
        {
            for (int i = 0; i <= 5; i++)
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
        }

        void IsPortOpen(string ipaddress, int port)
        {
            using (var tcpClient = new TcpClient())
            {
                try
                {
                    var result = tcpClient.BeginConnect(ipaddress, port, null, null);
                    var success = result.AsyncWaitHandle.WaitOne(100);
                    tcpClient.EndConnect(result);
                    Debug.WriteLine(success.ToString() + ipaddress + ":" + port);
                    //return success;
                }
                catch (Exception)
                {
                    Debug.WriteLine("Port closed " + ipaddress + ":" + port);
                    //return false;
                }
            }
        }
    }
}
