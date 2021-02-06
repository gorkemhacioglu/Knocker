namespace Knocker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStartScan = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusIndicator = new System.Windows.Forms.Label();
            this.lblRunningThreads = new System.Windows.Forms.Label();
            this.lblRunningThreadsIndicator = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStartHost = new System.Windows.Forms.Label();
            this.lblHosts = new System.Windows.Forms.Label();
            this.lblEndingHost = new System.Windows.Forms.Label();
            this.txtFromHostIp = new System.Windows.Forms.TextBox();
            this.txtToHostIp = new System.Windows.Forms.TextBox();
            this.lblPorts = new System.Windows.Forms.Label();
            this.lblFromPort = new System.Windows.Forms.Label();
            this.lblToPort = new System.Windows.Forms.Label();
            this.txtFromPort = new System.Windows.Forms.TextBox();
            this.txtToPort = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblInfoHeader = new System.Windows.Forms.Label();
            this.infoMessageDisplayer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLimitationValue = new System.Windows.Forms.Label();
            this.trcLimitation = new System.Windows.Forms.TrackBar();
            this.openPortsDataGrid = new System.Windows.Forms.DataGridView();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartScan)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcLimitation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openPortsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.53815F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.46185F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.openPortsDataGrid, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.progressBar, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(890, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel2.Controls.Add(this.btnStartScan, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblStatus, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblStatusIndicator, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblRunningThreads, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblRunningThreadsIndicator, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(643, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(244, 139);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnStartScan
            // 
            this.btnStartScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStartScan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStartScan.Image = ((System.Drawing.Image)(resources.GetObject("btnStartScan.Image")));
            this.btnStartScan.Location = new System.Drawing.Point(3, 88);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(156, 48);
            this.btnStartScan.TabIndex = 4;
            this.btnStartScan.TabStop = false;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Location = new System.Drawing.Point(3, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(156, 40);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status:";
            // 
            // lblStatusIndicator
            // 
            this.lblStatusIndicator.AutoSize = true;
            this.lblStatusIndicator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusIndicator.Location = new System.Drawing.Point(165, 0);
            this.lblStatusIndicator.Name = "lblStatusIndicator";
            this.lblStatusIndicator.Size = new System.Drawing.Size(76, 40);
            this.lblStatusIndicator.TabIndex = 1;
            this.lblStatusIndicator.Text = "Stopped";
            this.lblStatusIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRunningThreads
            // 
            this.lblRunningThreads.AutoSize = true;
            this.lblRunningThreads.Location = new System.Drawing.Point(3, 40);
            this.lblRunningThreads.Name = "lblRunningThreads";
            this.lblRunningThreads.Size = new System.Drawing.Size(96, 15);
            this.lblRunningThreads.TabIndex = 2;
            this.lblRunningThreads.Text = "Running Threads";
            // 
            // lblRunningThreadsIndicator
            // 
            this.lblRunningThreadsIndicator.AutoSize = true;
            this.lblRunningThreadsIndicator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRunningThreadsIndicator.Location = new System.Drawing.Point(165, 40);
            this.lblRunningThreadsIndicator.Name = "lblRunningThreadsIndicator";
            this.lblRunningThreadsIndicator.Size = new System.Drawing.Size(76, 22);
            this.lblRunningThreadsIndicator.TabIndex = 3;
            this.lblRunningThreadsIndicator.Text = "0";
            this.lblRunningThreadsIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.77778F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.22222F));
            this.tableLayoutPanel3.Controls.Add(this.lblStartHost, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblHosts, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblEndingHost, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtFromHostIp, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtToHostIp, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblPorts, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblFromPort, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblToPort, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.txtFromPort, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtToPort, 1, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.70968F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.93548F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(215, 139);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // lblStartHost
            // 
            this.lblStartHost.AutoSize = true;
            this.lblStartHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStartHost.Location = new System.Drawing.Point(3, 13);
            this.lblStartHost.Name = "lblStartHost";
            this.lblStartHost.Size = new System.Drawing.Size(107, 25);
            this.lblStartHost.TabIndex = 0;
            this.lblStartHost.Text = "From:";
            this.lblStartHost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHosts
            // 
            this.lblHosts.AutoSize = true;
            this.lblHosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHosts.Location = new System.Drawing.Point(3, 0);
            this.lblHosts.Name = "lblHosts";
            this.lblHosts.Size = new System.Drawing.Size(107, 13);
            this.lblHosts.TabIndex = 1;
            this.lblHosts.Text = "Host Information IP";
            this.lblHosts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEndingHost
            // 
            this.lblEndingHost.AutoSize = true;
            this.lblEndingHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEndingHost.Location = new System.Drawing.Point(3, 38);
            this.lblEndingHost.Name = "lblEndingHost";
            this.lblEndingHost.Size = new System.Drawing.Size(107, 27);
            this.lblEndingHost.TabIndex = 2;
            this.lblEndingHost.Text = "To:";
            this.lblEndingHost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFromHostIp
            // 
            this.txtFromHostIp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFromHostIp.Location = new System.Drawing.Point(116, 16);
            this.txtFromHostIp.Name = "txtFromHostIp";
            this.txtFromHostIp.PlaceholderText = "xxx.xxx.xxx.xxx";
            this.txtFromHostIp.Size = new System.Drawing.Size(96, 23);
            this.txtFromHostIp.TabIndex = 3;
            this.txtFromHostIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFromHostIp.TextChanged += new System.EventHandler(this.txtFromHostIp_TextChanged);
            // 
            // txtToHostIp
            // 
            this.txtToHostIp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtToHostIp.Location = new System.Drawing.Point(116, 41);
            this.txtToHostIp.Name = "txtToHostIp";
            this.txtToHostIp.PlaceholderText = "xxx.xxx.xxx.xxx";
            this.txtToHostIp.Size = new System.Drawing.Size(96, 23);
            this.txtToHostIp.TabIndex = 4;
            this.txtToHostIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtToHostIp.TextChanged += new System.EventHandler(this.txtToHostIp_TextChanged);
            // 
            // lblPorts
            // 
            this.lblPorts.AutoSize = true;
            this.lblPorts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPorts.Location = new System.Drawing.Point(3, 65);
            this.lblPorts.Name = "lblPorts";
            this.lblPorts.Size = new System.Drawing.Size(107, 15);
            this.lblPorts.TabIndex = 5;
            this.lblPorts.Text = "Port Information";
            this.lblPorts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFromPort
            // 
            this.lblFromPort.AutoSize = true;
            this.lblFromPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFromPort.Location = new System.Drawing.Point(3, 80);
            this.lblFromPort.Name = "lblFromPort";
            this.lblFromPort.Size = new System.Drawing.Size(107, 26);
            this.lblFromPort.TabIndex = 6;
            this.lblFromPort.Text = "From:";
            this.lblFromPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblToPort
            // 
            this.lblToPort.AutoSize = true;
            this.lblToPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToPort.Location = new System.Drawing.Point(3, 106);
            this.lblToPort.Name = "lblToPort";
            this.lblToPort.Size = new System.Drawing.Size(107, 33);
            this.lblToPort.TabIndex = 7;
            this.lblToPort.Text = "To:";
            this.lblToPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFromPort
            // 
            this.txtFromPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFromPort.Location = new System.Drawing.Point(116, 83);
            this.txtFromPort.Name = "txtFromPort";
            this.txtFromPort.PlaceholderText = "1-65535";
            this.txtFromPort.Size = new System.Drawing.Size(96, 23);
            this.txtFromPort.TabIndex = 8;
            this.txtFromPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFromPort.TextChanged += new System.EventHandler(this.txtFromPort_TextChanged);
            // 
            // txtToPort
            // 
            this.txtToPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtToPort.Location = new System.Drawing.Point(116, 109);
            this.txtToPort.Name = "txtToPort";
            this.txtToPort.PlaceholderText = "1-65535";
            this.txtToPort.Size = new System.Drawing.Size(96, 23);
            this.txtToPort.TabIndex = 9;
            this.txtToPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtToPort.TextChanged += new System.EventHandler(this.txtToPort_TextChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.38716F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.61284F));
            this.tableLayoutPanel4.Controls.Add(this.lblInfoHeader, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.infoMessageDisplayer, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(224, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.06837F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.93162F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(413, 139);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // lblInfoHeader
            // 
            this.lblInfoHeader.AutoSize = true;
            this.lblInfoHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfoHeader.Location = new System.Drawing.Point(3, 0);
            this.lblInfoHeader.Name = "lblInfoHeader";
            this.lblInfoHeader.Size = new System.Drawing.Size(41, 105);
            this.lblInfoHeader.TabIndex = 0;
            this.lblInfoHeader.Text = "Info";
            this.lblInfoHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // infoMessageDisplayer
            // 
            this.infoMessageDisplayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoMessageDisplayer.Location = new System.Drawing.Point(50, 3);
            this.infoMessageDisplayer.Multiline = true;
            this.infoMessageDisplayer.Name = "infoMessageDisplayer";
            this.infoMessageDisplayer.ReadOnly = true;
            this.infoMessageDisplayer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoMessageDisplayer.Size = new System.Drawing.Size(360, 79);
            this.infoMessageDisplayer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 56);
            this.label1.TabIndex = 9;
            this.label1.Text = "Limitation:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.lblLimitationValue, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.trcLimitation, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(224, 148);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.92308F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.07692F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(413, 50);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // lblLimitationValue
            // 
            this.lblLimitationValue.AutoSize = true;
            this.lblLimitationValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLimitationValue.Location = new System.Drawing.Point(3, 0);
            this.lblLimitationValue.Name = "lblLimitationValue";
            this.lblLimitationValue.Size = new System.Drawing.Size(407, 13);
            this.lblLimitationValue.TabIndex = 0;
            this.lblLimitationValue.Text = "500";
            this.lblLimitationValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trcLimitation
            // 
            this.trcLimitation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trcLimitation.LargeChange = 50;
            this.trcLimitation.Location = new System.Drawing.Point(3, 16);
            this.trcLimitation.Maximum = 1000;
            this.trcLimitation.Minimum = 1;
            this.trcLimitation.Name = "trcLimitation";
            this.trcLimitation.Size = new System.Drawing.Size(407, 31);
            this.trcLimitation.TabIndex = 1;
            this.trcLimitation.Value = 500;
            this.trcLimitation.ValueChanged += new System.EventHandler(this.trcLimitation_ValueChanged);
            this.trcLimitation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.trcLimitation_ValueChanged);
            // 
            // openPortsDataGrid
            // 
            this.openPortsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.openPortsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openPortsDataGrid.Location = new System.Drawing.Point(224, 204);
            this.openPortsDataGrid.Name = "openPortsDataGrid";
            this.openPortsDataGrid.RowTemplate.Height = 25;
            this.openPortsDataGrid.Size = new System.Drawing.Size(413, 293);
            this.openPortsDataGrid.TabIndex = 11;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(643, 148);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(244, 50);
            this.progressBar.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Port Knocker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartScan)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcLimitation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openPortsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusIndicator;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblStartHost;
        private System.Windows.Forms.Label lblHosts;
        private System.Windows.Forms.Label lblEndingHost;
        private System.Windows.Forms.TextBox txtFromHostIp;
        private System.Windows.Forms.TextBox txtToHostIp;
        private System.Windows.Forms.Label lblPorts;
        private System.Windows.Forms.Label lblFromPort;
        private System.Windows.Forms.Label lblToPort;
        private System.Windows.Forms.TextBox txtFromPort;
        private System.Windows.Forms.TextBox txtToPort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblInfoHeader;
        private System.Windows.Forms.TextBox infoMessageDisplayer;
        private System.Windows.Forms.Label lblRunningThreads;
        private System.Windows.Forms.Label lblRunningThreadsIndicator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblLimitationValue;
        private System.Windows.Forms.DataGridView openPortsDataGrid;
        private System.Windows.Forms.TrackBar trcLimitation;
        private System.Windows.Forms.PictureBox btnStartScan;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

