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
            this.btnStartScan = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusIndicator = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartScan)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.53815F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.46185F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.Controls.Add(this.btnStartScan, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(890, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnStartScan
            // 
            this.btnStartScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStartScan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStartScan.Image = ((System.Drawing.Image)(resources.GetObject("btnStartScan.Image")));
            this.btnStartScan.Location = new System.Drawing.Point(750, 449);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(137, 48);
            this.btnStartScan.TabIndex = 0;
            this.btnStartScan.TabStop = false;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel2.Controls.Add(this.lblStatus, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblStatusIndicator, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(750, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(137, 134);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(3, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 15);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status:";
            // 
            // lblStatusIndicator
            // 
            this.lblStatusIndicator.AutoSize = true;
            this.lblStatusIndicator.Location = new System.Drawing.Point(58, 0);
            this.lblStatusIndicator.Name = "lblStatusIndicator";
            this.lblStatusIndicator.Size = new System.Drawing.Size(51, 15);
            this.lblStatusIndicator.TabIndex = 1;
            this.lblStatusIndicator.Text = "Stopped";
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
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.61111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.05556F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(252, 134);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // lblStartHost
            // 
            this.lblStartHost.AutoSize = true;
            this.lblStartHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStartHost.Location = new System.Drawing.Point(3, 15);
            this.lblStartHost.Name = "lblStartHost";
            this.lblStartHost.Size = new System.Drawing.Size(127, 27);
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
            this.lblHosts.Size = new System.Drawing.Size(127, 15);
            this.lblHosts.TabIndex = 1;
            this.lblHosts.Text = "Host Information IP";
            this.lblHosts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEndingHost
            // 
            this.lblEndingHost.AutoSize = true;
            this.lblEndingHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEndingHost.Location = new System.Drawing.Point(3, 42);
            this.lblEndingHost.Name = "lblEndingHost";
            this.lblEndingHost.Size = new System.Drawing.Size(127, 21);
            this.lblEndingHost.TabIndex = 2;
            this.lblEndingHost.Text = "To:";
            this.lblEndingHost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFromHostIp
            // 
            this.txtFromHostIp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFromHostIp.Location = new System.Drawing.Point(136, 18);
            this.txtFromHostIp.Name = "txtFromHostIp";
            this.txtFromHostIp.PlaceholderText = "xxx.xxx.xxx.xxx";
            this.txtFromHostIp.Size = new System.Drawing.Size(113, 23);
            this.txtFromHostIp.TabIndex = 3;
            this.txtFromHostIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFromHostIp.TextChanged += new System.EventHandler(this.txtFromHostIp_TextChanged);
            // 
            // txtToHostIp
            // 
            this.txtToHostIp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtToHostIp.Location = new System.Drawing.Point(136, 45);
            this.txtToHostIp.Name = "txtToHostIp";
            this.txtToHostIp.PlaceholderText = "xxx.xxx.xxx.xxx";
            this.txtToHostIp.Size = new System.Drawing.Size(113, 23);
            this.txtToHostIp.TabIndex = 4;
            this.txtToHostIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtToHostIp.TextChanged += new System.EventHandler(this.txtToHostIp_TextChanged);
            // 
            // lblPorts
            // 
            this.lblPorts.AutoSize = true;
            this.lblPorts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPorts.Location = new System.Drawing.Point(3, 63);
            this.lblPorts.Name = "lblPorts";
            this.lblPorts.Size = new System.Drawing.Size(127, 14);
            this.lblPorts.TabIndex = 5;
            this.lblPorts.Text = "Port Information";
            this.lblPorts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFromPort
            // 
            this.lblFromPort.AutoSize = true;
            this.lblFromPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFromPort.Location = new System.Drawing.Point(3, 77);
            this.lblFromPort.Name = "lblFromPort";
            this.lblFromPort.Size = new System.Drawing.Size(127, 27);
            this.lblFromPort.TabIndex = 6;
            this.lblFromPort.Text = "From:";
            this.lblFromPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblToPort
            // 
            this.lblToPort.AutoSize = true;
            this.lblToPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToPort.Location = new System.Drawing.Point(3, 104);
            this.lblToPort.Name = "lblToPort";
            this.lblToPort.Size = new System.Drawing.Size(127, 30);
            this.lblToPort.TabIndex = 7;
            this.lblToPort.Text = "To:";
            this.lblToPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFromPort
            // 
            this.txtFromPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFromPort.Location = new System.Drawing.Point(136, 80);
            this.txtFromPort.Name = "txtFromPort";
            this.txtFromPort.PlaceholderText = "1-65535";
            this.txtFromPort.Size = new System.Drawing.Size(113, 23);
            this.txtFromPort.TabIndex = 8;
            this.txtFromPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFromPort.TextChanged += new System.EventHandler(this.txtFromPort_TextChanged);
            // 
            // txtToPort
            // 
            this.txtToPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtToPort.Location = new System.Drawing.Point(136, 107);
            this.txtToPort.Name = "txtToPort";
            this.txtToPort.PlaceholderText = "1-65535";
            this.txtToPort.Size = new System.Drawing.Size(113, 23);
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(261, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.0597F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.9403F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(483, 134);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // lblInfoHeader
            // 
            this.lblInfoHeader.AutoSize = true;
            this.lblInfoHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfoHeader.Location = new System.Drawing.Point(3, 0);
            this.lblInfoHeader.Name = "lblInfoHeader";
            this.lblInfoHeader.Size = new System.Drawing.Size(48, 51);
            this.lblInfoHeader.TabIndex = 0;
            this.lblInfoHeader.Text = "Info";
            this.lblInfoHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoMessageDisplayer
            // 
            this.infoMessageDisplayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoMessageDisplayer.Location = new System.Drawing.Point(57, 3);
            this.infoMessageDisplayer.Multiline = true;
            this.infoMessageDisplayer.Name = "infoMessageDisplayer";
            this.infoMessageDisplayer.ReadOnly = true;
            this.infoMessageDisplayer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoMessageDisplayer.Size = new System.Drawing.Size(423, 45);
            this.infoMessageDisplayer.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnStartScan)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox btnStartScan;
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
    }
}

