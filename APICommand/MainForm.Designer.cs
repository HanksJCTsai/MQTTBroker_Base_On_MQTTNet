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
            this.txtInputCommand = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.txtCommandInfo, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.txtInputCommand, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.45313F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.54688F));
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
            this.txtCommandInfo.Location = new System.Drawing.Point(2, 2);
            this.txtCommandInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCommandInfo.Multiline = true;
            this.txtCommandInfo.Name = "txtCommandInfo";
            this.txtCommandInfo.ReadOnly = true;
            this.txtCommandInfo.Size = new System.Drawing.Size(1020, 683);
            this.txtCommandInfo.TabIndex = 0;
            this.txtCommandInfo.Text = "11111111111111111111\r\n22222222222222222222222\r\n33333333333333333333333";
            // 
            // txtInputCommand
            // 
            this.txtInputCommand.BackColor = System.Drawing.Color.Gainsboro;
            this.txtInputCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInputCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputCommand.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputCommand.Location = new System.Drawing.Point(2, 689);
            this.txtInputCommand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInputCommand.Multiline = true;
            this.txtInputCommand.Name = "txtInputCommand";
            this.txtInputCommand.Size = new System.Drawing.Size(1020, 77);
            this.txtInputCommand.TabIndex = 1;
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
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TextBox txtCommandInfo;
        private System.Windows.Forms.TextBox txtInputCommand;
    }
}

