namespace APICommand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.txtCommandInfo = new System.Windows.Forms.TextBox();
            this.splitContainerOpenAPIFile = new System.Windows.Forms.SplitContainer();
            this.txtAPIPath = new System.Windows.Forms.TextBox();
            this.btnSelectAPIPAth = new System.Windows.Forms.Button();
            this.splitContainerStartAPI = new System.Windows.Forms.SplitContainer();
            this.txtCMD = new System.Windows.Forms.TextBox();
            this.btnSendCMD = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOpenAPIFile)).BeginInit();
            this.splitContainerOpenAPIFile.Panel1.SuspendLayout();
            this.splitContainerOpenAPIFile.Panel2.SuspendLayout();
            this.splitContainerOpenAPIFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerStartAPI)).BeginInit();
            this.splitContainerStartAPI.Panel1.SuspendLayout();
            this.splitContainerStartAPI.Panel2.SuspendLayout();
            this.splitContainerStartAPI.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.txtCommandInfo, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.splitContainerOpenAPIFile, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.splitContainerStartAPI, 0, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.149011F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.85099F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1024, 768);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // txtCommandInfo
            // 
            this.txtCommandInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtCommandInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommandInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCommandInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommandInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(194)))), ((int)(((byte)(14)))));
            this.txtCommandInfo.Location = new System.Drawing.Point(2, 58);
            this.txtCommandInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCommandInfo.Multiline = true;
            this.txtCommandInfo.Name = "txtCommandInfo";
            this.txtCommandInfo.ReadOnly = true;
            this.txtCommandInfo.Size = new System.Drawing.Size(1020, 638);
            this.txtCommandInfo.TabIndex = 0;
            // 
            // splitContainerOpenAPIFile
            // 
            this.splitContainerOpenAPIFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerOpenAPIFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerOpenAPIFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainerOpenAPIFile.Location = new System.Drawing.Point(2, 2);
            this.splitContainerOpenAPIFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainerOpenAPIFile.Name = "splitContainerOpenAPIFile";
            // 
            // splitContainerOpenAPIFile.Panel1
            // 
            this.splitContainerOpenAPIFile.Panel1.Controls.Add(this.txtAPIPath);
            // 
            // splitContainerOpenAPIFile.Panel2
            // 
            this.splitContainerOpenAPIFile.Panel2.Controls.Add(this.btnSelectAPIPAth);
            this.splitContainerOpenAPIFile.Size = new System.Drawing.Size(1020, 52);
            this.splitContainerOpenAPIFile.SplitterDistance = 800;
            this.splitContainerOpenAPIFile.SplitterWidth = 3;
            this.splitContainerOpenAPIFile.TabIndex = 2;
            // 
            // txtAPIPath
            // 
            this.txtAPIPath.BackColor = System.Drawing.Color.Black;
            this.txtAPIPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAPIPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAPIPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPIPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(194)))), ((int)(((byte)(14)))));
            this.txtAPIPath.Location = new System.Drawing.Point(0, 0);
            this.txtAPIPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAPIPath.Multiline = true;
            this.txtAPIPath.Name = "txtAPIPath";
            this.txtAPIPath.ReadOnly = true;
            this.txtAPIPath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAPIPath.Size = new System.Drawing.Size(798, 50);
            this.txtAPIPath.TabIndex = 0;
            // 
            // btnSelectAPIPAth
            // 
            this.btnSelectAPIPAth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectAPIPAth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectAPIPAth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSelectAPIPAth.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAPIPAth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnSelectAPIPAth.Location = new System.Drawing.Point(0, 0);
            this.btnSelectAPIPAth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectAPIPAth.Name = "btnSelectAPIPAth";
            this.btnSelectAPIPAth.Size = new System.Drawing.Size(215, 50);
            this.btnSelectAPIPAth.TabIndex = 35;
            this.btnSelectAPIPAth.Text = "Opne API";
            this.btnSelectAPIPAth.UseVisualStyleBackColor = true;
            // 
            // splitContainerStartAPI
            // 
            this.splitContainerStartAPI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerStartAPI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerStartAPI.Location = new System.Drawing.Point(2, 700);
            this.splitContainerStartAPI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainerStartAPI.Name = "splitContainerStartAPI";
            // 
            // splitContainerStartAPI.Panel1
            // 
            this.splitContainerStartAPI.Panel1.Controls.Add(this.txtCMD);
            // 
            // splitContainerStartAPI.Panel2
            // 
            this.splitContainerStartAPI.Panel2.Controls.Add(this.btnSendCMD);
            this.splitContainerStartAPI.Size = new System.Drawing.Size(1020, 66);
            this.splitContainerStartAPI.SplitterDistance = 800;
            this.splitContainerStartAPI.SplitterWidth = 3;
            this.splitContainerStartAPI.TabIndex = 3;
            // 
            // txtCMD
            // 
            this.txtCMD.BackColor = System.Drawing.Color.White;
            this.txtCMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCMD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMD.ForeColor = System.Drawing.Color.Black;
            this.txtCMD.Location = new System.Drawing.Point(0, 0);
            this.txtCMD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCMD.Multiline = true;
            this.txtCMD.Name = "txtCMD";
            this.txtCMD.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCMD.Size = new System.Drawing.Size(798, 64);
            this.txtCMD.TabIndex = 1;
            // 
            // btnSendCMD
            // 
            this.btnSendCMD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSendCMD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSendCMD.Enabled = false;
            this.btnSendCMD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSendCMD.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCMD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnSendCMD.Location = new System.Drawing.Point(0, 0);
            this.btnSendCMD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSendCMD.Name = "btnSendCMD";
            this.btnSendCMD.Size = new System.Drawing.Size(215, 64);
            this.btnSendCMD.TabIndex = 36;
            this.btnSendCMD.Text = "Send CMD";
            this.btnSendCMD.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "API Command";
            this.Text = "API Command";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.splitContainerOpenAPIFile.Panel1.ResumeLayout(false);
            this.splitContainerOpenAPIFile.Panel1.PerformLayout();
            this.splitContainerOpenAPIFile.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOpenAPIFile)).EndInit();
            this.splitContainerOpenAPIFile.ResumeLayout(false);
            this.splitContainerStartAPI.Panel1.ResumeLayout(false);
            this.splitContainerStartAPI.Panel1.PerformLayout();
            this.splitContainerStartAPI.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerStartAPI)).EndInit();
            this.splitContainerStartAPI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TextBox txtCommandInfo;
        private System.Windows.Forms.SplitContainer splitContainerOpenAPIFile;
        private System.Windows.Forms.TextBox txtAPIPath;
        private System.Windows.Forms.Button btnSelectAPIPAth;
        private System.Windows.Forms.SplitContainer splitContainerStartAPI;
        private System.Windows.Forms.Button btnSendCMD;
        private System.Windows.Forms.TextBox txtCMD;
    }
}

