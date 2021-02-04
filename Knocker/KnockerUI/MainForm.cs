using KnockerCore;
using KnockerCore.DTO;
using KnockerCore.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knocker
{
    public partial class MainForm : Form
    {
        private MainStatusDto _mainStatus = new KnockerCore.DTO.MainStatusDto();

        private RegexChecker _regexChecker = new RegexChecker();

        private ResourceManager _resourceManager = new ResourceManager("KnockerUI.Strings", Assembly.GetExecutingAssembly());

        private Core core = new Core();

        public MainForm()
        {
            InitializeComponent();

            Debug.WriteLine("çalıştı");
        }

        private void btnStartScan_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_mainStatus.IsRunning && IsReady())
                {
                    //Starting to scan

                    int fromPort = 0;
                    int toPort = 0;
                    bool fPort = Int32.TryParse(txtFromPort.Text, out fromPort);
                    bool tPort = Int32.TryParse(txtToPort.Text, out toPort);

                    if (fPort && tPort)
                    {
                        var ret = core.StartScanning(txtFromHostIp.Text, txtToHostIp.Text, fromPort, toPort);
                        if (ret)
                            AddToInfo("PortIsOpen");
                        else
                            AddToInfo("PortIsClosed");

                        lblStatusIndicator.Text = GetFromResource("Running");
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
                {
                    //Stopping scan

                    lblStatusIndicator.Text = GetFromResource("Stopped");
                    _mainStatus.IsRunning = false;
                    btnStartScan.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\button_start.png");
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtFromHostIp_TextChanged(object sender, EventArgs e)
        {
            var hostIp = txtFromHostIp.Text;

            bool res = _regexChecker.CheckIpAddress(hostIp);

            if (!res)
            {
                _mainStatus.ComponentStatus.isFromHostValid = false; 
                txtFromHostIp.ForeColor = Color.Red;
                AddToInfo("FromHostIpNotOk");
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
            var hostIp = txtToHostIp.Text;

            bool res = _regexChecker.CheckIpAddress(hostIp);

            if (!res)
            {
                _mainStatus.ComponentStatus.isToHostValid = false;
                txtToHostIp.ForeColor = Color.Red;
                AddToInfo("ToHostIpNotOk");
            }
            else
            {
                _mainStatus.ComponentStatus.isToHostValid = true;
                txtToHostIp.ForeColor = Color.Black;
                DeleteFromInfo("ToHostIpNotOk");
            }
        }

        private bool IsReady() {

            var stat = _mainStatus.ComponentStatus;

            if (stat.isFromHostValid && stat.isFromPortValid && stat.isToHostValid && stat.isToPortValid)
            {
                DeleteFromInfo("InputAreNotReady");
                return true;
            }
            else
            {
                AddToInfo("InputAreNotReady");
                return false;
            }
        }

        private void txtFromPort_TextChanged(object sender, EventArgs e)
        {
            var port = txtFromPort.Text;

            bool res = _regexChecker.CheckPortValue(port);

            if (!res)
            {
                _mainStatus.ComponentStatus.isFromPortValid = false;
                txtFromPort.ForeColor = Color.Red;
                AddToInfo("FromPortValueNotOk");
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
            var port = txtToPort.Text;

            bool res = _regexChecker.CheckPortValue(port);

            if (!res)
            {
                _mainStatus.ComponentStatus.isToPortValid = false;
                txtToPort.ForeColor = Color.Red;
                AddToInfo("ToPortValueNotOk");
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

        private void AddToInfo(string key) {

            var text = GetFromResource(key);

            if (!String.IsNullOrEmpty(text) && !infoMessageDisplayer.Text.Contains(text))
                infoMessageDisplayer.Text += text;
        }
        private void DeleteFromInfo(string key)
        {
            var res = GetFromResource(key);

            if (!String.IsNullOrEmpty(res))
            {
                infoMessageDisplayer.Text = infoMessageDisplayer.Text.Replace(res, String.Empty);
            }
        }
    }
}
