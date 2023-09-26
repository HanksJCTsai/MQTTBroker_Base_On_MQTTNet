using System.Windows.Forms;

namespace LightMeter
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.scSettings = new System.Windows.Forms.SplitContainer();
            this.gboxSettings = new System.Windows.Forms.GroupBox();
            this.txtMsgTestConnect = new System.Windows.Forms.TextBox();
            this.btnTestConnect = new System.Windows.Forms.Button();
            this.cboStopBit = new MetroFramework.Controls.MetroComboBox();
            this.lblStopBit = new System.Windows.Forms.Label();
            this.cboParity = new MetroFramework.Controls.MetroComboBox();
            this.lblParity = new System.Windows.Forms.Label();
            this.cboDataBits = new MetroFramework.Controls.MetroComboBox();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.cboBaudRate = new MetroFramework.Controls.MetroComboBox();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.cboPort = new MetroFramework.Controls.MetroComboBox();
            this.lblPortName = new System.Windows.Forms.Label();
            this.scExecute = new System.Windows.Forms.SplitContainer();
            this.gboxThread = new System.Windows.Forms.GroupBox();
            this.txtMsgIntervalLog = new System.Windows.Forms.TextBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtIntervalTime = new System.Windows.Forms.TextBox();
            this.lblIntervalTime = new System.Windows.Forms.Label();
            this.gboxReceiveInfo = new System.Windows.Forms.GroupBox();
            this.lblGRYXY_Y2 = new System.Windows.Forms.Label();
            this.lblGRYXY_X = new System.Windows.Forms.Label();
            this.lblGRYXY_Y1 = new System.Windows.Forms.Label();
            this.lblGRXYZ_Z = new System.Windows.Forms.Label();
            this.lblGRXYZ_Y = new System.Windows.Forms.Label();
            this.lblGRXYZ_X = new System.Windows.Forms.Label();
            this.txtGRYXY_Y2 = new System.Windows.Forms.TextBox();
            this.txtGRYXY_X = new System.Windows.Forms.TextBox();
            this.txtGRYXY_Y1 = new System.Windows.Forms.TextBox();
            this.txtGRXYZ_Z = new System.Windows.Forms.TextBox();
            this.txtGRXYZ_Y = new System.Windows.Forms.TextBox();
            this.txtGRXYZ_X = new System.Windows.Forms.TextBox();
            this.txtGRL = new System.Windows.Forms.TextBox();
            this.txtGRCCT = new System.Windows.Forms.TextBox();
            this.btnSendCMD = new System.Windows.Forms.Button();
            this.cboCMD = new MetroFramework.Controls.MetroComboBox();
            this.lblCMD = new System.Windows.Forms.Label();
            this.lblGRYXY = new System.Windows.Forms.Label();
            this.lblGRXYZ = new System.Windows.Forms.Label();
            this.lblGRL = new System.Windows.Forms.Label();
            this.lblGRCCT = new System.Windows.Forms.Label();
            this.scReceiveData = new System.Windows.Forms.SplitContainer();
            this.gboxSendOutLog = new System.Windows.Forms.GroupBox();
            this.txtSendOutCMD = new System.Windows.Forms.TextBox();
            this.gboxMeterReceiveMsg = new System.Windows.Forms.GroupBox();
            this.txtMsgReceive = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSettings)).BeginInit();
            this.scSettings.Panel1.SuspendLayout();
            this.scSettings.Panel2.SuspendLayout();
            this.scSettings.SuspendLayout();
            this.gboxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scExecute)).BeginInit();
            this.scExecute.Panel1.SuspendLayout();
            this.scExecute.Panel2.SuspendLayout();
            this.scExecute.SuspendLayout();
            this.gboxThread.SuspendLayout();
            this.gboxReceiveInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scReceiveData)).BeginInit();
            this.scReceiveData.Panel1.SuspendLayout();
            this.scReceiveData.Panel2.SuspendLayout();
            this.scReceiveData.SuspendLayout();
            this.gboxSendOutLog.SuspendLayout();
            this.gboxMeterReceiveMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.scSettings);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.scReceiveData);
            this.scMain.Size = new System.Drawing.Size(1024, 768);
            this.scMain.SplitterDistance = 520;
            this.scMain.TabIndex = 0;
            // 
            // scSettings
            // 
            this.scSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSettings.Location = new System.Drawing.Point(0, 0);
            this.scSettings.Name = "scSettings";
            // 
            // scSettings.Panel1
            // 
            this.scSettings.Panel1.Controls.Add(this.gboxSettings);
            this.scSettings.Panel1.ForeColor = System.Drawing.Color.Gainsboro;
            // 
            // scSettings.Panel2
            // 
            this.scSettings.Panel2.Controls.Add(this.scExecute);
            this.scSettings.Size = new System.Drawing.Size(1024, 520);
            this.scSettings.SplitterDistance = 283;
            this.scSettings.TabIndex = 0;
            // 
            // gboxSettings
            // 
            this.gboxSettings.Controls.Add(this.txtMsgTestConnect);
            this.gboxSettings.Controls.Add(this.btnTestConnect);
            this.gboxSettings.Controls.Add(this.cboStopBit);
            this.gboxSettings.Controls.Add(this.lblStopBit);
            this.gboxSettings.Controls.Add(this.cboParity);
            this.gboxSettings.Controls.Add(this.lblParity);
            this.gboxSettings.Controls.Add(this.cboDataBits);
            this.gboxSettings.Controls.Add(this.lblDataBits);
            this.gboxSettings.Controls.Add(this.cboBaudRate);
            this.gboxSettings.Controls.Add(this.lblBaudRate);
            this.gboxSettings.Controls.Add(this.cboPort);
            this.gboxSettings.Controls.Add(this.lblPortName);
            this.gboxSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxSettings.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.gboxSettings.Location = new System.Drawing.Point(0, 0);
            this.gboxSettings.Name = "gboxSettings";
            this.gboxSettings.Size = new System.Drawing.Size(281, 518);
            this.gboxSettings.TabIndex = 0;
            this.gboxSettings.TabStop = false;
            this.gboxSettings.Text = "SETTINGS";
            // 
            // txtMsgTestConnect
            // 
            this.txtMsgTestConnect.BackColor = System.Drawing.Color.Black;
            this.txtMsgTestConnect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMsgTestConnect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMsgTestConnect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsgTestConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(194)))), ((int)(((byte)(14)))));
            this.txtMsgTestConnect.Location = new System.Drawing.Point(3, 331);
            this.txtMsgTestConnect.Multiline = true;
            this.txtMsgTestConnect.Name = "txtMsgTestConnect";
            this.txtMsgTestConnect.ReadOnly = true;
            this.txtMsgTestConnect.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMsgTestConnect.Size = new System.Drawing.Size(275, 184);
            this.txtMsgTestConnect.TabIndex = 23;
            this.txtMsgTestConnect.Text = "11111";
            // 
            // btnTestConnect
            // 
            this.btnTestConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTestConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTestConnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTestConnect.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnTestConnect.Location = new System.Drawing.Point(39, 263);
            this.btnTestConnect.Name = "btnTestConnect";
            this.btnTestConnect.Size = new System.Drawing.Size(180, 50);
            this.btnTestConnect.TabIndex = 22;
            this.btnTestConnect.Text = "TEST CONNECT";
            this.btnTestConnect.UseVisualStyleBackColor = true;
            // 
            // cboStopBit
            // 
            this.cboStopBit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboStopBit.DropDownHeight = 100;
            this.cboStopBit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboStopBit.FormattingEnabled = true;
            this.cboStopBit.IntegralHeight = false;
            this.cboStopBit.ItemHeight = 23;
            this.cboStopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cboStopBit.Location = new System.Drawing.Point(125, 219);
            this.cboStopBit.Name = "cboStopBit";
            this.cboStopBit.Size = new System.Drawing.Size(150, 29);
            this.cboStopBit.TabIndex = 21;
            this.cboStopBit.UseSelectable = true;
            // 
            // lblStopBit
            // 
            this.lblStopBit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStopBit.AutoSize = true;
            this.lblStopBit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblStopBit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopBit.Location = new System.Drawing.Point(6, 223);
            this.lblStopBit.Name = "lblStopBit";
            this.lblStopBit.Size = new System.Drawing.Size(102, 22);
            this.lblStopBit.TabIndex = 20;
            this.lblStopBit.Text = "STOP BIT:";
            // 
            // cboParity
            // 
            this.cboParity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboParity.DropDownHeight = 100;
            this.cboParity.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboParity.FormattingEnabled = true;
            this.cboParity.IntegralHeight = false;
            this.cboParity.ItemHeight = 23;
            this.cboParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.cboParity.Location = new System.Drawing.Point(125, 172);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(150, 29);
            this.cboParity.TabIndex = 19;
            this.cboParity.UseSelectable = true;
            // 
            // lblParity
            // 
            this.lblParity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblParity.AutoSize = true;
            this.lblParity.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblParity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParity.Location = new System.Drawing.Point(6, 176);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(84, 22);
            this.lblParity.TabIndex = 18;
            this.lblParity.Text = "PARITY:";
            // 
            // cboDataBits
            // 
            this.cboDataBits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboDataBits.DropDownHeight = 100;
            this.cboDataBits.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboDataBits.FormattingEnabled = true;
            this.cboDataBits.IntegralHeight = false;
            this.cboDataBits.ItemHeight = 23;
            this.cboDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cboDataBits.Location = new System.Drawing.Point(125, 125);
            this.cboDataBits.Name = "cboDataBits";
            this.cboDataBits.Size = new System.Drawing.Size(150, 29);
            this.cboDataBits.TabIndex = 17;
            this.cboDataBits.UseSelectable = true;
            // 
            // lblDataBits
            // 
            this.lblDataBits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDataBits.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataBits.Location = new System.Drawing.Point(6, 129);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(114, 22);
            this.lblDataBits.TabIndex = 16;
            this.lblDataBits.Text = "DATA BITS:";
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboBaudRate.DropDownHeight = 100;
            this.cboBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.IntegralHeight = false;
            this.cboBaudRate.ItemHeight = 23;
            this.cboBaudRate.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.cboBaudRate.Location = new System.Drawing.Point(125, 78);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(150, 29);
            this.cboBaudRate.TabIndex = 15;
            this.cboBaudRate.UseSelectable = true;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblBaudRate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaudRate.Location = new System.Drawing.Point(6, 82);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(125, 22);
            this.lblBaudRate.TabIndex = 14;
            this.lblBaudRate.Text = "BAUD RATE:";
            // 
            // cboPort
            // 
            this.cboPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboPort.DropDownHeight = 100;
            this.cboPort.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboPort.FormattingEnabled = true;
            this.cboPort.IntegralHeight = false;
            this.cboPort.ItemHeight = 23;
            this.cboPort.Location = new System.Drawing.Point(70, 31);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(205, 29);
            this.cboPort.TabIndex = 13;
            this.cboPort.UseSelectable = true;
            // 
            // lblPortName
            // 
            this.lblPortName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPortName.AutoSize = true;
            this.lblPortName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPortName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortName.Location = new System.Drawing.Point(6, 35);
            this.lblPortName.Name = "lblPortName";
            this.lblPortName.Size = new System.Drawing.Size(67, 22);
            this.lblPortName.TabIndex = 12;
            this.lblPortName.Text = "PORT:";
            // 
            // scExecute
            // 
            this.scExecute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scExecute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scExecute.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scExecute.Location = new System.Drawing.Point(0, 0);
            this.scExecute.Name = "scExecute";
            // 
            // scExecute.Panel1
            // 
            this.scExecute.Panel1.Controls.Add(this.gboxThread);
            this.scExecute.Panel1.ForeColor = System.Drawing.Color.Gainsboro;
            // 
            // scExecute.Panel2
            // 
            this.scExecute.Panel2.Controls.Add(this.gboxReceiveInfo);
            this.scExecute.Size = new System.Drawing.Size(737, 520);
            this.scExecute.SplitterDistance = 250;
            this.scExecute.TabIndex = 0;
            // 
            // gboxThread
            // 
            this.gboxThread.Controls.Add(this.txtMsgIntervalLog);
            this.gboxThread.Controls.Add(this.btnPause);
            this.gboxThread.Controls.Add(this.btnStop);
            this.gboxThread.Controls.Add(this.btnPlay);
            this.gboxThread.Controls.Add(this.txtIntervalTime);
            this.gboxThread.Controls.Add(this.lblIntervalTime);
            this.gboxThread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxThread.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxThread.ForeColor = System.Drawing.Color.Gainsboro;
            this.gboxThread.Location = new System.Drawing.Point(0, 0);
            this.gboxThread.Name = "gboxThread";
            this.gboxThread.Size = new System.Drawing.Size(248, 518);
            this.gboxThread.TabIndex = 0;
            this.gboxThread.TabStop = false;
            this.gboxThread.Text = "INTERVAL";
            // 
            // txtMsgIntervalLog
            // 
            this.txtMsgIntervalLog.BackColor = System.Drawing.Color.Black;
            this.txtMsgIntervalLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMsgIntervalLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMsgIntervalLog.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsgIntervalLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(194)))), ((int)(((byte)(14)))));
            this.txtMsgIntervalLog.Location = new System.Drawing.Point(3, 331);
            this.txtMsgIntervalLog.Multiline = true;
            this.txtMsgIntervalLog.Name = "txtMsgIntervalLog";
            this.txtMsgIntervalLog.ReadOnly = true;
            this.txtMsgIntervalLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMsgIntervalLog.Size = new System.Drawing.Size(242, 184);
            this.txtMsgIntervalLog.TabIndex = 21;
            this.txtMsgIntervalLog.Text = "11111";
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPause.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnPause.Location = new System.Drawing.Point(66, 206);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(120, 50);
            this.btnPause.TabIndex = 20;
            this.btnPause.Text = "PAUSE";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnStop.Location = new System.Drawing.Point(66, 265);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(120, 50);
            this.btnStop.TabIndex = 19;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPlay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnPlay.Location = new System.Drawing.Point(66, 147);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(120, 50);
            this.btnPlay.TabIndex = 18;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // txtIntervalTime
            // 
            this.txtIntervalTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIntervalTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtIntervalTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIntervalTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIntervalTime.Font = new System.Drawing.Font("DS-Digital", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntervalTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtIntervalTime.Location = new System.Drawing.Point(78, 67);
            this.txtIntervalTime.Name = "txtIntervalTime";
            this.txtIntervalTime.ReadOnly = true;
            this.txtIntervalTime.Size = new System.Drawing.Size(90, 71);
            this.txtIntervalTime.TabIndex = 17;
            this.txtIntervalTime.Text = "10";
            this.txtIntervalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIntervalTime
            // 
            this.lblIntervalTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIntervalTime.AutoSize = true;
            this.lblIntervalTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblIntervalTime.Font = new System.Drawing.Font("DS-Digital", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervalTime.Location = new System.Drawing.Point(30, 28);
            this.lblIntervalTime.Name = "lblIntervalTime";
            this.lblIntervalTime.Size = new System.Drawing.Size(186, 30);
            this.lblIntervalTime.TabIndex = 16;
            this.lblIntervalTime.Text = "INTERVAL TIME";
            // 
            // gboxReceiveInfo
            // 
            this.gboxReceiveInfo.Controls.Add(this.lblGRYXY_Y2);
            this.gboxReceiveInfo.Controls.Add(this.lblGRYXY_X);
            this.gboxReceiveInfo.Controls.Add(this.lblGRYXY_Y1);
            this.gboxReceiveInfo.Controls.Add(this.lblGRXYZ_Z);
            this.gboxReceiveInfo.Controls.Add(this.lblGRXYZ_Y);
            this.gboxReceiveInfo.Controls.Add(this.lblGRXYZ_X);
            this.gboxReceiveInfo.Controls.Add(this.txtGRYXY_Y2);
            this.gboxReceiveInfo.Controls.Add(this.txtGRYXY_X);
            this.gboxReceiveInfo.Controls.Add(this.txtGRYXY_Y1);
            this.gboxReceiveInfo.Controls.Add(this.txtGRXYZ_Z);
            this.gboxReceiveInfo.Controls.Add(this.txtGRXYZ_Y);
            this.gboxReceiveInfo.Controls.Add(this.txtGRXYZ_X);
            this.gboxReceiveInfo.Controls.Add(this.txtGRL);
            this.gboxReceiveInfo.Controls.Add(this.txtGRCCT);
            this.gboxReceiveInfo.Controls.Add(this.btnSendCMD);
            this.gboxReceiveInfo.Controls.Add(this.cboCMD);
            this.gboxReceiveInfo.Controls.Add(this.lblCMD);
            this.gboxReceiveInfo.Controls.Add(this.lblGRYXY);
            this.gboxReceiveInfo.Controls.Add(this.lblGRXYZ);
            this.gboxReceiveInfo.Controls.Add(this.lblGRL);
            this.gboxReceiveInfo.Controls.Add(this.lblGRCCT);
            this.gboxReceiveInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxReceiveInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxReceiveInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.gboxReceiveInfo.Location = new System.Drawing.Point(0, 0);
            this.gboxReceiveInfo.Name = "gboxReceiveInfo";
            this.gboxReceiveInfo.Size = new System.Drawing.Size(481, 518);
            this.gboxReceiveInfo.TabIndex = 0;
            this.gboxReceiveInfo.TabStop = false;
            this.gboxReceiveInfo.Text = "INFO";
            // 
            // lblGRYXY_Y2
            // 
            this.lblGRYXY_Y2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGRYXY_Y2.AutoSize = true;
            this.lblGRYXY_Y2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblGRYXY_Y2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRYXY_Y2.Location = new System.Drawing.Point(410, 189);
            this.lblGRYXY_Y2.Name = "lblGRYXY_Y2";
            this.lblGRYXY_Y2.Size = new System.Drawing.Size(23, 22);
            this.lblGRYXY_Y2.TabIndex = 48;
            this.lblGRYXY_Y2.Text = "Y";
            // 
            // lblGRYXY_X
            // 
            this.lblGRYXY_X.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGRYXY_X.AutoSize = true;
            this.lblGRYXY_X.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblGRYXY_X.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRYXY_X.Location = new System.Drawing.Point(285, 189);
            this.lblGRYXY_X.Name = "lblGRYXY_X";
            this.lblGRYXY_X.Size = new System.Drawing.Size(23, 22);
            this.lblGRYXY_X.TabIndex = 47;
            this.lblGRYXY_X.Text = "X";
            // 
            // lblGRYXY_Y1
            // 
            this.lblGRYXY_Y1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGRYXY_Y1.AutoSize = true;
            this.lblGRYXY_Y1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblGRYXY_Y1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRYXY_Y1.Location = new System.Drawing.Point(161, 189);
            this.lblGRYXY_Y1.Name = "lblGRYXY_Y1";
            this.lblGRYXY_Y1.Size = new System.Drawing.Size(23, 22);
            this.lblGRYXY_Y1.TabIndex = 46;
            this.lblGRYXY_Y1.Text = "Y";
            // 
            // lblGRXYZ_Z
            // 
            this.lblGRXYZ_Z.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGRXYZ_Z.AutoSize = true;
            this.lblGRXYZ_Z.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblGRXYZ_Z.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRXYZ_Z.Location = new System.Drawing.Point(410, 121);
            this.lblGRXYZ_Z.Name = "lblGRXYZ_Z";
            this.lblGRXYZ_Z.Size = new System.Drawing.Size(22, 22);
            this.lblGRXYZ_Z.TabIndex = 45;
            this.lblGRXYZ_Z.Text = "Z";
            // 
            // lblGRXYZ_Y
            // 
            this.lblGRXYZ_Y.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGRXYZ_Y.AutoSize = true;
            this.lblGRXYZ_Y.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblGRXYZ_Y.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRXYZ_Y.Location = new System.Drawing.Point(285, 121);
            this.lblGRXYZ_Y.Name = "lblGRXYZ_Y";
            this.lblGRXYZ_Y.Size = new System.Drawing.Size(23, 22);
            this.lblGRXYZ_Y.TabIndex = 44;
            this.lblGRXYZ_Y.Text = "Y";
            // 
            // lblGRXYZ_X
            // 
            this.lblGRXYZ_X.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGRXYZ_X.AutoSize = true;
            this.lblGRXYZ_X.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblGRXYZ_X.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRXYZ_X.Location = new System.Drawing.Point(161, 121);
            this.lblGRXYZ_X.Name = "lblGRXYZ_X";
            this.lblGRXYZ_X.Size = new System.Drawing.Size(23, 22);
            this.lblGRXYZ_X.TabIndex = 37;
            this.lblGRXYZ_X.Text = "X";
            // 
            // txtGRYXY_Y2
            // 
            this.txtGRYXY_Y2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGRYXY_Y2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtGRYXY_Y2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGRYXY_Y2.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGRYXY_Y2.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtGRYXY_Y2.Location = new System.Drawing.Point(359, 213);
            this.txtGRYXY_Y2.Name = "txtGRYXY_Y2";
            this.txtGRYXY_Y2.ReadOnly = true;
            this.txtGRYXY_Y2.Size = new System.Drawing.Size(117, 36);
            this.txtGRYXY_Y2.TabIndex = 43;
            this.txtGRYXY_Y2.Text = "1234.4321";
            // 
            // txtGRYXY_X
            // 
            this.txtGRYXY_X.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGRYXY_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtGRYXY_X.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGRYXY_X.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGRYXY_X.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtGRYXY_X.Location = new System.Drawing.Point(236, 213);
            this.txtGRYXY_X.Name = "txtGRYXY_X";
            this.txtGRYXY_X.ReadOnly = true;
            this.txtGRYXY_X.Size = new System.Drawing.Size(117, 36);
            this.txtGRYXY_X.TabIndex = 42;
            this.txtGRYXY_X.Text = "1234.4321";
            // 
            // txtGRYXY_Y1
            // 
            this.txtGRYXY_Y1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGRYXY_Y1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtGRYXY_Y1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGRYXY_Y1.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGRYXY_Y1.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtGRYXY_Y1.Location = new System.Drawing.Point(113, 213);
            this.txtGRYXY_Y1.Name = "txtGRYXY_Y1";
            this.txtGRYXY_Y1.ReadOnly = true;
            this.txtGRYXY_Y1.Size = new System.Drawing.Size(117, 36);
            this.txtGRYXY_Y1.TabIndex = 41;
            this.txtGRYXY_Y1.Text = "1234.4321";
            // 
            // txtGRXYZ_Z
            // 
            this.txtGRXYZ_Z.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGRXYZ_Z.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtGRXYZ_Z.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGRXYZ_Z.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGRXYZ_Z.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtGRXYZ_Z.Location = new System.Drawing.Point(359, 145);
            this.txtGRXYZ_Z.Name = "txtGRXYZ_Z";
            this.txtGRXYZ_Z.ReadOnly = true;
            this.txtGRXYZ_Z.Size = new System.Drawing.Size(117, 36);
            this.txtGRXYZ_Z.TabIndex = 40;
            this.txtGRXYZ_Z.Text = "1234.4321";
            // 
            // txtGRXYZ_Y
            // 
            this.txtGRXYZ_Y.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGRXYZ_Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtGRXYZ_Y.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGRXYZ_Y.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGRXYZ_Y.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtGRXYZ_Y.Location = new System.Drawing.Point(236, 145);
            this.txtGRXYZ_Y.Name = "txtGRXYZ_Y";
            this.txtGRXYZ_Y.ReadOnly = true;
            this.txtGRXYZ_Y.Size = new System.Drawing.Size(117, 36);
            this.txtGRXYZ_Y.TabIndex = 39;
            this.txtGRXYZ_Y.Text = "1234.4321";
            // 
            // txtGRXYZ_X
            // 
            this.txtGRXYZ_X.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGRXYZ_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtGRXYZ_X.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGRXYZ_X.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGRXYZ_X.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtGRXYZ_X.Location = new System.Drawing.Point(113, 145);
            this.txtGRXYZ_X.Name = "txtGRXYZ_X";
            this.txtGRXYZ_X.ReadOnly = true;
            this.txtGRXYZ_X.Size = new System.Drawing.Size(117, 36);
            this.txtGRXYZ_X.TabIndex = 38;
            this.txtGRXYZ_X.Text = "1234.4321";
            // 
            // txtGRL
            // 
            this.txtGRL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGRL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtGRL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGRL.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGRL.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtGRL.Location = new System.Drawing.Point(113, 84);
            this.txtGRL.Name = "txtGRL";
            this.txtGRL.ReadOnly = true;
            this.txtGRL.Size = new System.Drawing.Size(117, 36);
            this.txtGRL.TabIndex = 36;
            this.txtGRL.Text = "1234.4321";
            // 
            // txtGRCCT
            // 
            this.txtGRCCT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGRCCT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtGRCCT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGRCCT.Font = new System.Drawing.Font("DS-Digital", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGRCCT.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtGRCCT.Location = new System.Drawing.Point(113, 24);
            this.txtGRCCT.Name = "txtGRCCT";
            this.txtGRCCT.ReadOnly = true;
            this.txtGRCCT.Size = new System.Drawing.Size(117, 36);
            this.txtGRCCT.TabIndex = 35;
            this.txtGRCCT.Text = "1234.4321";
            // 
            // btnSendCMD
            // 
            this.btnSendCMD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSendCMD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSendCMD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSendCMD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCMD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnSendCMD.Location = new System.Drawing.Point(358, 269);
            this.btnSendCMD.Name = "btnSendCMD";
            this.btnSendCMD.Size = new System.Drawing.Size(86, 45);
            this.btnSendCMD.TabIndex = 34;
            this.btnSendCMD.Text = "SEND";
            this.btnSendCMD.UseVisualStyleBackColor = true;
            // 
            // cboCMD
            // 
            this.cboCMD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCMD.DropDownHeight = 100;
            this.cboCMD.DropDownWidth = 240;
            this.cboCMD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboCMD.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cboCMD.FormattingEnabled = true;
            this.cboCMD.IntegralHeight = false;
            this.cboCMD.ItemHeight = 29;
            this.cboCMD.Items.AddRange(new object[] {
            "ALL",
            "GRCCT",
            "GRL",
            "GRXYZ",
            "GRYXY"});
            this.cboCMD.Location = new System.Drawing.Point(113, 275);
            this.cboCMD.Name = "cboCMD";
            this.cboCMD.Size = new System.Drawing.Size(239, 35);
            this.cboCMD.TabIndex = 33;
            this.cboCMD.UseSelectable = true;
            // 
            // lblCMD
            // 
            this.lblCMD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCMD.AutoSize = true;
            this.lblCMD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCMD.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMD.Location = new System.Drawing.Point(33, 281);
            this.lblCMD.Name = "lblCMD";
            this.lblCMD.Size = new System.Drawing.Size(77, 25);
            this.lblCMD.TabIndex = 32;
            this.lblCMD.Text = "CMD:";
            // 
            // lblGRYXY
            // 
            this.lblGRYXY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGRYXY.AutoSize = true;
            this.lblGRYXY.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblGRYXY.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRYXY.Location = new System.Drawing.Point(13, 220);
            this.lblGRYXY.Name = "lblGRYXY";
            this.lblGRYXY.Size = new System.Drawing.Size(97, 25);
            this.lblGRYXY.TabIndex = 31;
            this.lblGRYXY.Text = "GRYXY:";
            // 
            // lblGRXYZ
            // 
            this.lblGRXYZ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGRXYZ.AutoSize = true;
            this.lblGRXYZ.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblGRXYZ.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRXYZ.Location = new System.Drawing.Point(11, 152);
            this.lblGRXYZ.Name = "lblGRXYZ";
            this.lblGRXYZ.Size = new System.Drawing.Size(99, 25);
            this.lblGRXYZ.TabIndex = 30;
            this.lblGRXYZ.Text = "GRXYZ:";
            // 
            // lblGRL
            // 
            this.lblGRL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGRL.AutoSize = true;
            this.lblGRL.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblGRL.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRL.Location = new System.Drawing.Point(40, 91);
            this.lblGRL.Name = "lblGRL";
            this.lblGRL.Size = new System.Drawing.Size(70, 25);
            this.lblGRL.TabIndex = 29;
            this.lblGRL.Text = "GRL:";
            // 
            // lblGRCCT
            // 
            this.lblGRCCT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGRCCT.AutoSize = true;
            this.lblGRCCT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblGRCCT.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRCCT.Location = new System.Drawing.Point(8, 31);
            this.lblGRCCT.Name = "lblGRCCT";
            this.lblGRCCT.Size = new System.Drawing.Size(102, 25);
            this.lblGRCCT.TabIndex = 28;
            this.lblGRCCT.Text = "GRCCT:";
            // 
            // scReceiveData
            // 
            this.scReceiveData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scReceiveData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scReceiveData.Location = new System.Drawing.Point(0, 0);
            this.scReceiveData.Name = "scReceiveData";
            // 
            // scReceiveData.Panel1
            // 
            this.scReceiveData.Panel1.Controls.Add(this.gboxSendOutLog);
            // 
            // scReceiveData.Panel2
            // 
            this.scReceiveData.Panel2.Controls.Add(this.gboxMeterReceiveMsg);
            this.scReceiveData.Size = new System.Drawing.Size(1024, 244);
            this.scReceiveData.SplitterDistance = 512;
            this.scReceiveData.TabIndex = 0;
            // 
            // gboxSendOutLog
            // 
            this.gboxSendOutLog.Controls.Add(this.txtSendOutCMD);
            this.gboxSendOutLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxSendOutLog.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxSendOutLog.ForeColor = System.Drawing.Color.Gainsboro;
            this.gboxSendOutLog.Location = new System.Drawing.Point(0, 0);
            this.gboxSendOutLog.Name = "gboxSendOutLog";
            this.gboxSendOutLog.Size = new System.Drawing.Size(510, 242);
            this.gboxSendOutLog.TabIndex = 18;
            this.gboxSendOutLog.TabStop = false;
            this.gboxSendOutLog.Text = "SEND OUT CMD";
            // 
            // txtSendOutCMD
            // 
            this.txtSendOutCMD.BackColor = System.Drawing.Color.Black;
            this.txtSendOutCMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSendOutCMD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSendOutCMD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSendOutCMD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(194)))), ((int)(((byte)(14)))));
            this.txtSendOutCMD.Location = new System.Drawing.Point(3, 25);
            this.txtSendOutCMD.Multiline = true;
            this.txtSendOutCMD.Name = "txtSendOutCMD";
            this.txtSendOutCMD.ReadOnly = true;
            this.txtSendOutCMD.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSendOutCMD.Size = new System.Drawing.Size(504, 214);
            this.txtSendOutCMD.TabIndex = 18;
            this.txtSendOutCMD.Text = "11111";
            // 
            // gboxMeterReceiveMsg
            // 
            this.gboxMeterReceiveMsg.Controls.Add(this.txtMsgReceive);
            this.gboxMeterReceiveMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxMeterReceiveMsg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxMeterReceiveMsg.ForeColor = System.Drawing.Color.Gainsboro;
            this.gboxMeterReceiveMsg.Location = new System.Drawing.Point(0, 0);
            this.gboxMeterReceiveMsg.Name = "gboxMeterReceiveMsg";
            this.gboxMeterReceiveMsg.Size = new System.Drawing.Size(506, 242);
            this.gboxMeterReceiveMsg.TabIndex = 17;
            this.gboxMeterReceiveMsg.TabStop = false;
            this.gboxMeterReceiveMsg.Text = "RECEIVE MESSAGES";
            // 
            // txtMsgReceive
            // 
            this.txtMsgReceive.BackColor = System.Drawing.Color.Black;
            this.txtMsgReceive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMsgReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMsgReceive.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsgReceive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(194)))), ((int)(((byte)(14)))));
            this.txtMsgReceive.Location = new System.Drawing.Point(3, 25);
            this.txtMsgReceive.Multiline = true;
            this.txtMsgReceive.Name = "txtMsgReceive";
            this.txtMsgReceive.ReadOnly = true;
            this.txtMsgReceive.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMsgReceive.Size = new System.Drawing.Size(500, 214);
            this.txtMsgReceive.TabIndex = 17;
            this.txtMsgReceive.Text = "11111";
            // 
            // MainForm
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.scMain);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "LightMeter";
            this.Text = "LightMeter";
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scSettings.Panel1.ResumeLayout(false);
            this.scSettings.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSettings)).EndInit();
            this.scSettings.ResumeLayout(false);
            this.gboxSettings.ResumeLayout(false);
            this.gboxSettings.PerformLayout();
            this.scExecute.Panel1.ResumeLayout(false);
            this.scExecute.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scExecute)).EndInit();
            this.scExecute.ResumeLayout(false);
            this.gboxThread.ResumeLayout(false);
            this.gboxThread.PerformLayout();
            this.gboxReceiveInfo.ResumeLayout(false);
            this.gboxReceiveInfo.PerformLayout();
            this.scReceiveData.Panel1.ResumeLayout(false);
            this.scReceiveData.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scReceiveData)).EndInit();
            this.scReceiveData.ResumeLayout(false);
            this.gboxSendOutLog.ResumeLayout(false);
            this.gboxSendOutLog.PerformLayout();
            this.gboxMeterReceiveMsg.ResumeLayout(false);
            this.gboxMeterReceiveMsg.PerformLayout();
            this.ResumeLayout(false);

        }

        private SplitContainer scMain;
        private SplitContainer scReceiveData;
        private SplitContainer scSettings;
        private SplitContainer scExecute;
        #endregion

        private GroupBox gboxReceiveInfo;
        private Label lblGRYXY_Y2;
        private Label lblGRYXY_X;
        private Label lblGRYXY_Y1;
        private Label lblGRXYZ_Z;
        private Label lblGRXYZ_Y;
        private Label lblGRXYZ_X;
        private TextBox txtGRYXY_Y2;
        private TextBox txtGRYXY_X;
        private TextBox txtGRYXY_Y1;
        private TextBox txtGRXYZ_Z;
        private TextBox txtGRXYZ_Y;
        private TextBox txtGRXYZ_X;
        private TextBox txtGRL;
        private TextBox txtGRCCT;
        private Button btnSendCMD;
        private MetroFramework.Controls.MetroComboBox cboCMD;
        private Label lblCMD;
        private Label lblGRYXY;
        private Label lblGRXYZ;
        private Label lblGRL;
        private Label lblGRCCT;
        private GroupBox gboxSendOutLog;
        private TextBox txtSendOutCMD;
        private GroupBox gboxMeterReceiveMsg;
        private TextBox txtMsgReceive;
        private GroupBox gboxThread;
        private TextBox txtMsgIntervalLog;
        private Button btnPause;
        private Button btnStop;
        private Button btnPlay;
        private TextBox txtIntervalTime;
        private Label lblIntervalTime;
        private GroupBox gboxSettings;
        private TextBox txtMsgTestConnect;
        private Button btnTestConnect;
        private MetroFramework.Controls.MetroComboBox cboStopBit;
        private Label lblStopBit;
        private MetroFramework.Controls.MetroComboBox cboParity;
        private Label lblParity;
        private MetroFramework.Controls.MetroComboBox cboDataBits;
        private Label lblDataBits;
        private MetroFramework.Controls.MetroComboBox cboBaudRate;
        private Label lblBaudRate;
        private MetroFramework.Controls.MetroComboBox cboPort;
        private Label lblPortName;
    }
}