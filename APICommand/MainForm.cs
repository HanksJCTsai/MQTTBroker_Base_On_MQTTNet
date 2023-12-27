using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APICommand
{
    public partial class MainForm : Form
    {
        private OpenFileDialog openAPIFileDialog = new OpenFileDialog();
        private string defaultFilePath = string.Empty;

        public MainForm()
        {
            InitializeComponent();
        }

        // write out info to the display window
        private void build_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            string strMessage = e.Data;
            if (string.IsNullOrEmpty(strMessage))
            {
                this.txtCommandInfo.Text += strMessage;
            }
        }

        private EventHandler CreateEventButton_SendCMD()
        {
            return (sender, e) =>
            {
                Process mainProcess = new Process()
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = this.txtAPIPath.Text,                    // 執行檔路徑
                        Arguments = this.txtCMD.Text.Trim(),                // 執行時傳入的引數
                        UseShellExecute = false,                 // 是否要使用作業系統 shell 來啟動處理程序
                        CreateNoWindow = false,                  // 是否要在新視窗中啟動處理程序
                        WindowStyle = ProcessWindowStyle.Hidden, // 新視窗的顯示方式
                        RedirectStandardOutput = true,           // 應用程式的文字輸出是否寫入至 StandardOutput 資料流
                        RedirectStandardError = true,            // 應用程式的錯誤輸出是否寫入至 StandardError 資料流
                    },
                };
                mainProcess.ErrorDataReceived += this.build_ErrorDataReceived;
                mainProcess.OutputDataReceived += this.build_ErrorDataReceived;
                mainProcess.EnableRaisingEvents = true;
                mainProcess.Start();
                mainProcess.BeginOutputReadLine();
                mainProcess.BeginErrorReadLine();
                mainProcess.WaitForExit();
            };
        }

        private EventHandler CreateEventButton_OpenAPI()
        {
            return (sender, e) =>
            {
                openAPIFileDialog = new OpenFileDialog();
                openAPIFileDialog.Title = "Select API file path";
                openAPIFileDialog.InitialDirectory = defaultFilePath;
                openAPIFileDialog.Filter = "API files (*.*)|*.exe";
                if (openAPIFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.txtAPIPath.Text = System.IO.Path.GetFullPath(openAPIFileDialog.FileName);
                    if (openAPIFileDialog.CheckFileExists)
                    {
                        this.btnSendCMD.Enabled = true;
                    }
                }
            };
        }

        private void AddButtonClickEvent()
        {
            ButtonFactory.CreateButtonEvent(this.btnSelectAPIPAth, this.CreateEventButton_OpenAPI());
            ButtonFactory.CreateButtonEvent(this.btnSendCMD, this.CreateEventButton_SendCMD());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.AddButtonClickEvent();
        }

    }
    public static class ButtonFactory
    {
        public static void CreateButtonEvent(Button triggerButton, EventHandler clickEvent)
        {
            if (triggerButton != null && clickEvent != null)
            {
                triggerButton.Click += clickEvent;
            }
        }
    }
}
