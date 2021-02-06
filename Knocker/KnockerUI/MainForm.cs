using CsvHelper;
using KnockerCore;
using KnockerCore.DTO;
using KnockerCore.DTO.Interface;
using KnockerCore.Helper;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KnockerCore.Helper.Factory;
using log4net;
using log4net.Config;

namespace Knocker
{
    public partial class MainForm : Form, IMessageListener
    {
        private MainStatusDto _mainStatus = new KnockerCore.DTO.MainStatusDto();

        private RegexChecker _regexChecker = new RegexChecker();

        private ResourceManager _resourceManager = new ResourceManager("KnockerUI.Strings", Assembly.GetExecutingAssembly());

        private BindingSource _gridBindingSource = new BindingSource();

        private static readonly ILog _log = LogManager.GetLogger("Knocker");

        private Core core = new Core();

        private Task _mainTask = null;

        private CancellationTokenSource _tokenSource = null;

        private int limitation = 500;

        public volatile int totalCalculatedAddresses;

        public volatile int scannedAddresses;

        public MainForm()
        {
            InitializeComponent();

            log4net.Config.XmlConfigurator.Configure();

            _log.Info(GetFromResource("AppStarted"));

            openPortsDataGrid.DataSource = _gridBindingSource;

            Broadcaster().AddListener(this);

            Task.Run(() =>
            {
                while (true)
                {
                    if (progressBar.InvokeRequired)
                    {
                        progressBar.BeginInvoke(new Action(() =>
                        {
                            progressBar.Maximum = totalCalculatedAddresses;
                            progressBar.Value = scannedAddresses;
                        }));
                    }
                    else
                    {
                        progressBar.Maximum = totalCalculatedAddresses;
                        progressBar.Value = scannedAddresses;
                    }
                    Thread.Sleep(1000);
                }
            });
        }

        private void btnStartScan_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_mainStatus.IsRunning && IsReady())
                {
                    _tokenSource = new CancellationTokenSource();
                    CancellationToken token = this._tokenSource.Token;
                    _gridBindingSource.Clear();
                    DeleteFromInfo("Completed");
                    int fromPort = 0;
                    int toPort = 0;
                    if (int.TryParse(txtFromPort.Text, out fromPort) & int.TryParse(txtToPort.Text, out toPort))
                    {
                        try
                        {
                            _mainTask = Task.Run((Action)(() => core.StartScanning(txtFromHostIp.Text, txtToHostIp.Text, fromPort, toPort, limitation, token)), _tokenSource.Token);
                        }
                        catch (OperationCanceledException)
                        {
                            _log.Info(GetFromResource("MainTaskCancelled"));
                        }
                        lblStatusIndicator.Text = GetFromResource("Running");
                        _log.Info(GetFromResource("MainTaskRunning"));
                        _mainStatus.IsRunning = true;
                        btnStartScan.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\button_stop.png");
                    }
                    else
                    {
                        _mainStatus.IsRunning = false;
                        infoMessageDisplayer.Text = GetFromResource("PortValuesNotOk");
                    }
                }
                else
                    StopCurrentTask();
            }
            catch (Exception ex)
            {
                _log.Error(GetFromResource("MainTaskError") + " " + ex);
            }
        }

        private void txtFromHostIp_TextChanged(object sender, EventArgs e)
        {
            if (!_regexChecker.CheckIpAddress(txtFromHostIp.Text))
            {
                _mainStatus.ComponentStatus.isFromHostValid = false;
                txtFromHostIp.ForeColor = Color.Red;
                AddToInfo("FromHostIpNotOk", false);
            }
            else
            {
                _mainStatus.ComponentStatus.isFromHostValid = true;
                txtFromHostIp.ForeColor = Color.Black;
                DeleteFromInfo("FromHostIpNotOk");
            }
        }

        private void txtToHostIp_TextChanged(object sender, EventArgs e)
        {
            if (!_regexChecker.CheckIpAddress(txtToHostIp.Text))
            {
                _mainStatus.ComponentStatus.isToHostValid = false;
                txtToHostIp.ForeColor = Color.Red;
                AddToInfo("ToHostIpNotOk", false);
            }
            else
            {
                _mainStatus.ComponentStatus.isToHostValid = true;
                txtToHostIp.ForeColor = Color.Black;
                DeleteFromInfo("ToHostIpNotOk");
            }
        }

        private void StopCurrentTask()
        {
            _tokenSource.Cancel();
            _mainStatus.IsRunning = false;
            _mainTask = null;
            btnStartScan.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\button_start.png");
            lblStatusIndicator.Text = GetFromResource("Stopped");
            _log.Info(GetFromResource("CurrentTaskStopped"));
        }

        private bool IsReady()
        {
            var stat = _mainStatus.ComponentStatus;

            if (stat.isFromHostValid && stat.isFromPortValid && stat.isToHostValid && stat.isToPortValid)
            {
                DeleteFromInfo("InputAreNotReady");
                return true;
            }
            else
            {
                AddToInfo("InputAreNotReady", false);
                return false;
            }
        }

        private void txtFromPort_TextChanged(object sender, EventArgs e)
        {

            if (!_regexChecker.CheckPortValue(txtFromPort.Text))
            {
                _mainStatus.ComponentStatus.isFromPortValid = false;
                txtFromPort.ForeColor = Color.Red;
                AddToInfo("FromPortValueNotOk", false);
            }
            else
            {
                _mainStatus.ComponentStatus.isFromPortValid = true;
                txtFromPort.ForeColor = Color.Black;
                DeleteFromInfo("FromPortValueNotOk");
            }
        }

        private void txtToPort_TextChanged(object sender, EventArgs e)
        {
            if (!_regexChecker.CheckPortValue(txtToPort.Text))
            {
                _mainStatus.ComponentStatus.isToPortValid = false;
                txtToPort.ForeColor = Color.Red;
                AddToInfo("ToPortValueNotOk", false);
            }
            else
            {
                _mainStatus.ComponentStatus.isToPortValid = true;
                txtToPort.ForeColor = Color.Black;
                DeleteFromInfo("ToPortValueNotOk");
            }
        }

        private string GetFromResource(string key)
        {
            var res = _resourceManager.GetString(key);

            return !String.IsNullOrEmpty(res) ? res + Environment.NewLine : "" + Environment.NewLine;
        }

        private void AddToInfo(string key, bool? dissapear)
        {

            var text = GetFromResource(key);

            if (infoMessageDisplayer.InvokeRequired)
            {
                infoMessageDisplayer.BeginInvoke(new Action(() =>
                {
                    if (!String.IsNullOrEmpty(text) && !infoMessageDisplayer.Text.Contains(text))
                        infoMessageDisplayer.Text += text;

                    if (Convert.ToBoolean(dissapear))
                    {
                        Thread thr = new Thread(() => { Thread.Sleep(15000); DeleteFromInfo(key); });
                        thr.Start();
                    }
                }));
            }
            else
            {
                if (!String.IsNullOrEmpty(text) && !infoMessageDisplayer.Text.Contains(text))
                    infoMessageDisplayer.Text += text;

                if (Convert.ToBoolean(dissapear))
                {
                    Thread thr = new Thread(() => { Thread.Sleep(15000); DeleteFromInfo(key); });
                    thr.Start();
                }
            }
        }
        private void DeleteFromInfo(string key)
        {
            var res = GetFromResource(key);

            if (!String.IsNullOrEmpty(res))
            {
                if (infoMessageDisplayer.InvokeRequired)
                {
                    infoMessageDisplayer.BeginInvoke(new Action(() =>
                    {
                        infoMessageDisplayer.Text = infoMessageDisplayer.Text.Replace(res, String.Empty);
                    }));
                }
                else
                    infoMessageDisplayer.Text = infoMessageDisplayer.Text.Replace(res, String.Empty);

            }
        }

        public void OnListen(string type, object data)
        {
            if (type == typeof(ThreadStatusDto).ToString())
            {
                var convertedObject = (ThreadStatusDto)data;

                Thread thr = new Thread(() =>
                {
                    if (openPortsDataGrid.InvokeRequired)
                    {
                        openPortsDataGrid.BeginInvoke(new Action(() =>
                        {
                            _gridBindingSource.Add(convertedObject);
                        }));
                    }
                    else
                    {
                        _gridBindingSource.Add(convertedObject);
                    }
                });
                thr.Start();
            }
            else if (type == typeof(MainStatusDto).ToString())
            {
                var convertedObject = (MainStatusDto)data;

                if (lblRunningThreadsIndicator.InvokeRequired)
                {
                    lblRunningThreadsIndicator.BeginInvoke(new Action(() =>
                    {
                        lblRunningThreadsIndicator.Text = convertedObject.RunningThreadCount.ToString();
                    }));
                }
                else
                {
                    lblRunningThreadsIndicator.Text = convertedObject.RunningThreadCount.ToString();
                }

                if (lblStatusIndicator.InvokeRequired)
                {
                    lblStatusIndicator.BeginInvoke(new Action(() =>
                    {
                        lblStatusIndicator.Text = convertedObject.IsRunning ? GetFromResource("Running") : GetFromResource("Stopped");
                    }));
                }
                else
                {
                    lblStatusIndicator.Text = convertedObject.IsRunning ? GetFromResource("Running") : GetFromResource("Stopped");
                }

                scannedAddresses = convertedObject.ScannedAddresses;

                totalCalculatedAddresses = convertedObject.TotalCalculatedAddresses;

                if (convertedObject.IsCompleted)
                    ScanCompleted();

            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Broadcaster().RemoveListener(this);
        }

        private void ScanCompleted()
        {
            AddToInfo("Completed", false);

            _log.Info(GetFromResource("Completed"));

            _mainStatus.IsRunning = false;

            if (btnStartScan.InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    btnStartScan.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\button_start.png");
                }));
            }
            else
            {
                btnStartScan.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\button_start.png");
            }
        }

        private void trcLimitation_ValueChanged(object sender, EventArgs e)
        {
            lblLimitationValue.Text = trcLimitation.Value.ToString();

            limitation = trcLimitation.Value;
            var previousLimit = core.limitation;

            if (_mainTask != null)
            {
                core.UpdateLimitation(limitation);

                if (previousLimit > limitation)
                    AddToInfo("WaitingThreadsToDecrease", true);
                else
                    AddToInfo("ThreadLimitIncreasing", true);
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (var writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".csv"))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(_gridBindingSource);
                    AddToInfo("Exported", true);
                    _log.Info(GetFromResource("Exported"));
                }
            }
            catch (Exception ex)
            {
                AddToInfo("NotExported", true);
                _log.Error(GetFromResource("NotExported") + " " + ex);
            }

        }
    }
}
