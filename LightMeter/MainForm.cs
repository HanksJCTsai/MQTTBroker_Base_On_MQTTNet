using LightMeter.BusinessLogic;
using LightMeter.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Drawing.Printing;
using System.Threading;
using System.Windows.Interop;
using System.Runtime.InteropServices;
using System.IO.Ports;
using MetroFramework.Controls;
using System.Windows.Markup;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.CompilerServices;

namespace LightMeter
{
    public partial class MainForm : Form
    {
        private bool isRun = true;
        private int secondsRemaining = 10;
        private string strAutoCMD = string.Empty;
        private string strConnectPort = string.Empty;
        private SerialPort MeterSerialPort = null;
        private ManagementEventWatcher watcher = new ManagementEventWatcher();
        private serialPortBusinessLogic getDefaultConfigClass = new serialPortBusinessLogic();
        private Thread readThread = null;
        private Thread intervalThread = null;

        public enum REFRESHGROUPBOX
        {
            gboxSettings = 1,
            gboxThread = 2,
            gboxReceiveInfo = 3,
            gboxSendOut = 4,
            gboxMeterReceive = 5
        }

        public enum REFRESHLOG
        {
            txtMsgTestConnectLog = 1,
            txtMsgIntervalLog = 2,
            txtSendOutCMDLog = 3,
            txtMsgReceiveLog = 4,
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.isRun = true;

            this.Initialize();
            this.AddComboBoxDataChangedEvent();
            this.AddButtonClickEvent();
            this.UIInitialize();
            this.StartManagementEventWatcher();

            if (this.cboPort.Text.Trim() == "Please Insert USB") this.btnTestConnect.Enabled = false; else this.btnPlay.Enabled = true;
        }

        #region Event
        private void UIInitialize()
        {
            if (!this.txtIntervalTime.Equals(null))
            {
                this.txtIntervalTime.Invoke((MethodInvoker)delegate
                {
                    this.txtIntervalTime.Text = secondsRemaining.ToString();
                });
            }

            if (!this.btnTestConnect.Equals(null))
            {
                this.btnTestConnect.Invoke((MethodInvoker)delegate
                {
                    this.btnTestConnect.Enabled = true;
                });
            }
                
            if (!this.btnPlay.Equals(null))
            {
                this.btnPlay.Invoke((MethodInvoker)delegate
                {
                    this.btnPlay.Enabled = false;
                });
            }

            if (!this.btnStop.Equals(null))
            {
                this.btnStop.Invoke((MethodInvoker)delegate
                {
                    this.btnStop.Enabled = false;
                });
            }

            if (!this.btnPause.Equals(null))
            {
                this.btnPause.Invoke((MethodInvoker)delegate
                {
                    this.btnPause.Enabled = false;
                });
            }

            if (!this.btnSendCMD.Equals(null))
            {
                this.btnSendCMD.Invoke((MethodInvoker)delegate
                {
                    this.btnSendCMD.Enabled = false;
                });
            }
        }

        private void Initialize()
        {
            //Get Initialize data from Json file.
            getDefaultConfigClass.GetSerialPortParameter(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName + @"\APPConfig\_serial_port_.json");

            this.cboPort.Items.AddRange((getDefaultConfigClass.GetPcPorts().ToArray().Length > 0) ? getDefaultConfigClass.GetPcPorts().ToArray() : new string[] { "Please Insert USB" });
            this.cboPort.Text = (getDefaultConfigClass.GetPcPorts().ToArray().Length > 0) ? (getDefaultConfigClass.GetPcPorts().ToArray()).Contains(getDefaultConfigClass.GetDefaultPort()) ? getDefaultConfigClass.GetDefaultPort() : (getDefaultConfigClass.GetPcPorts().ToArray())[0] : "Please Insert USB";

            this.cboBaudRate.Items.AddRange(this.getDefaultConfigClass.GetDefaultBaudRates().ToArray());
            this.cboBaudRate.Text = (getDefaultConfigClass.GetDefaultBaudRates().ToArray().Length > 0) ? (getDefaultConfigClass.GetDefaultBaudRates().ToArray()).Contains(getDefaultConfigClass.GetDefaultBaudRate()) ? getDefaultConfigClass.GetDefaultBaudRate() : (getDefaultConfigClass.GetDefaultBaudRates().ToArray())[0] : "No Serial Port Baud Rate";

            this.cboDataBits.Items.AddRange(getDefaultConfigClass.GetDefaultDataBits().ToArray());
            this.cboDataBits.Text = (getDefaultConfigClass.GetDefaultDataBits().ToArray().Length > 0) ? (getDefaultConfigClass.GetDefaultDataBits().ToArray()).Contains(getDefaultConfigClass.GetDefaultDataBit()) ? getDefaultConfigClass.GetDefaultDataBit() : getDefaultConfigClass.GetDefaultDataBits().ToArray()[0] : "No Serial Port Data Bits";

            this.cboStopBit.Items.AddRange(getDefaultConfigClass.GetDefaultStopBits().ToArray());
            this.cboStopBit.Text = (getDefaultConfigClass.GetDefaultStopBits().ToArray().Length > 0) ? (getDefaultConfigClass.GetDefaultStopBits().ToArray()).Contains(getDefaultConfigClass.GetDefaultStopBit()) ? getDefaultConfigClass.GetDefaultStopBit() : getDefaultConfigClass.GetDefaultStopBits().ToArray()[0] : "No Serial Port Stop Bit";

            this.cboParity.Items.AddRange(getDefaultConfigClass.GetDefaultParities().ToArray());
            this.cboParity.Text = (getDefaultConfigClass.GetDefaultParities().ToArray().Length > 0) ? (getDefaultConfigClass.GetDefaultParities().ToArray()).Contains(getDefaultConfigClass.GetDefaultParity()) ? getDefaultConfigClass.GetDefaultParity() : getDefaultConfigClass.GetDefaultParities().ToArray()[0] : "No Serial Port Data";

            this.cboCMD.Items.AddRange(getDefaultConfigClass.GetDefaultCMDs().ToArray());
            this.cboCMD.Text = (getDefaultConfigClass.GetDefaultCMDs().ToArray().Length > 0) ? getDefaultConfigClass.GetDefaultCMDs().ToArray()[0] : "No CMD Data";

            txtIntervalTime.Text = getDefaultConfigClass.GetDefaultIntervalTime().ToString();

            this.secondsRemaining = int.Parse(getDefaultConfigClass.GetDefaultIntervalTime());
            this.strAutoCMD = (getDefaultConfigClass.GetDefaultCMDs()).Aggregate((current, next) => string.Format("{0},{1}", current, next));
            this.strAutoCMD = this.strAutoCMD.Replace(",", "\r") + "\r";
        }

        private void AddButtonClickEvent()
        {
            ButtonFactory.CreateButtonEvent(this.btnTestConnect, this.CreateEventButton_TestConnect());
            ButtonFactory.CreateButtonEvent(this.btnPlay, this.CreateEventButton_Play());
            ButtonFactory.CreateButtonEvent(this.btnPause, this.CreateEventButton_Pause());
            ButtonFactory.CreateButtonEvent(this.btnStop, this.CreateEventButton_Stop());
            ButtonFactory.CreateButtonEvent(this.btnSendCMD, this.CreateEventButton_SendSingleCMD());
        }

        private void AddComboBoxDataChangedEvent()
        {
            MetroComboBoxFactory.CreateComboBoxDataChanged(this.cboPort, this.CreateEventComboBoxTextChanged_Port());
        }
        private void StartManagementEventWatcher()
        {
            WqlEventQuery query = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE (EventType = 2 or EventType = 3)");
            watcher.EventArrived += new EventArrivedEventHandler(watcher_EventArrived);
            watcher.Query = query;
            watcher.Start();
        }
        #endregion

        #region Main Methods
        public void gBoxSettingsControl(bool IsShow, GroupBox targetgBox)
        {
            try
            {
                List<Control> foundControls = FindControls(targetgBox, "");
                foreach (Control UIcontrol in foundControls)
                {
                    if (UIcontrol is MetroComboBox)
                    {
                        ((MetroComboBox)UIcontrol).Enabled = IsShow;
                    }
                    if (UIcontrol is Button)
                    {
                        ((Button)UIcontrol).Enabled = IsShow;
                    }
                }

                this.btnPlay.Enabled = !IsShow;
                this.btnStop.Enabled = IsShow;
                this.btnPause.Enabled = IsShow;
                this.btnSendCMD.Enabled = IsShow;
            }
            catch (Exception ex)
            {
                throw new Exception("The refresh UI had error:" + ex.Message);
            }
        }

        private void txtMsgRefresh(string message, REFRESHLOG type)
        {
            try
            {
                List<Control> foundControls = FindControls(this, type.ToString());
                if (((TextBox)foundControls[0]).InvokeRequired)
                {
                    ((TextBox)foundControls[0]).BeginInvoke(new Action<string>((msg) =>
                    {
                        ((TextBox)foundControls[0]).Text = msg;
                    }), ((DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ": " + message + Environment.NewLine + ((TextBox)foundControls[0]).Text)));
                }
                else
                {
                    ((TextBox)foundControls[0]).Text = (DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ": " + message + Environment.NewLine + ((TextBox)foundControls[0]).Text);
                    foundControls = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK);
            }
        }

        protected List<Control> FindControls(Control parent, string keyword)
        {
            List<Control> foundControls = new List<Control>();
            foreach (Control control in parent.Controls)
            {
                if (control.Name.Contains(keyword))
                {
                    foundControls.Add(control);
                }

                if (control.HasChildren)
                {
                    foundControls.AddRange(FindControls(control, keyword));
                }
            }
            return foundControls;
        }
        #endregion

        #region Event Methods
        private EventHandler CreateEventComboBoxTextChanged_Port()
        {
            return (sender, e) =>
            {
                if (this.cboPort.SelectedText.ToString().Contains("Please Insert USB")) this.btnTestConnect.Enabled = false; else this.btnTestConnect.Enabled = true;
            };
        }
        private EventHandler CreateEventButton_SendSingleCMD()
        {
            return (sender, e) =>
            {
                byte[] dataToSend = Encoding.ASCII.GetBytes(this.cboCMD.SelectedItem.ToString().Trim() + "\r");
                this.MeterSerialPort.Write(dataToSend, 0, dataToSend.Length);
                this.txtMsgRefresh("Send Single CMD:" + (this.cboCMD.SelectedItem.ToString().Trim().Replace("\r", ",").TrimEnd(',')), REFRESHLOG.txtSendOutCMDLog);
            };
        }
        private EventHandler CreateEventButton_Stop()
        {
            return (sender, e) =>
            {
                this.CloseConnect();
                this.UIInitialize();
                this.txtMsgRefresh("Interval Thread Stop", REFRESHLOG.txtMsgIntervalLog);
            };
        }
        private EventHandler CreateEventButton_Pause()
        {
            return (sender, e) =>
            {
                this.isRun = false;

                this.btnPlay.Enabled = true;
                this.btnPause.Enabled = false;
                this.btnStop.Enabled = true;

                this.txtMsgRefresh("Interval Thread Pause", REFRESHLOG.txtMsgIntervalLog);
            };
        }

        private EventHandler CreateEventButton_Play()
        {
            return (sender, e) =>
            {
                this.OpenConnect();

                this.btnPlay.Enabled = false;
                this.btnPause.Enabled = true;
                this.btnStop.Enabled = false;
                this.btnSendCMD.Enabled = true;
                this.btnTestConnect.Enabled = false;

                this.strConnectPort = cboPort.Text.Split('-')[0].ToString().Trim();

                this.txtMsgRefresh("Interval Thread Start", REFRESHLOG.txtMsgIntervalLog);
            };
        }

        private EventHandler CreateEventButton_TestConnect()
        {
            return (sender, e) =>
            {
                MeterSerialPort = new SerialPort();
                if (this.MeterSerialPort.IsOpen == false)
                {
                    if (this.MeterSerialPort != null)
                    {
                        this.MeterSerialPort = new SerialPort(this.cboPort.SelectedItem.ToString().Split('-')[0].ToString(), int.Parse(this.cboBaudRate.SelectedItem.ToString()), this.GetParityValue(this.cboParity.SelectedItem.ToString()), int.Parse(this.cboDataBits.SelectedItem.ToString()), (StopBits)int.Parse(this.cboStopBit.SelectedItem.ToString()));
                        this.MeterSerialPort.Open();

                        Thread.Sleep(1000);
                        if (this.MeterSerialPort.IsOpen)
                        {
                            this.txtMsgRefresh("Meter connection test successful!", REFRESHLOG.txtMsgTestConnectLog);
                        }
                        this.gBoxSettingsControl(false, gboxSettings);
                    }
                }
                else
                {
                    this.txtMsgRefresh("Meter is already connected!", REFRESHLOG.txtMsgTestConnectLog);
                }
            };
        }

        private Parity GetParityValue(string selectedParityValue)
        {
            Parity result = new Parity();
            switch (selectedParityValue)
            {
                case "None":
                    result = Parity.None;
                    break;
                case "Even":
                    result = Parity.Even;
                    break;
                case "Odd":
                    result = Parity.Odd;
                    break;
                case "Mark":
                    result = Parity.Mark;
                    break;
                case "Space":
                    result = Parity.Space;
                    break;
            }
            return result;
        }

        private void OpenConnect()
        {
            this.isRun = true;

            if (this.readThread == null)
            {
                this.readThread = new Thread(this.ReadMeter);
                this.readThread.Start();
            }
            if (this.intervalThread == null)
            {
                this.intervalThread = new Thread(this.StartCountdown);
                this.intervalThread.Start();
            }
            if (this.MeterSerialPort == null)
            {
                this.MeterSerialPort = new SerialPort();
                this.MeterSerialPort = new SerialPort(this.cboPort.SelectedItem.ToString().Split('-')[0].ToString(), int.Parse(this.cboBaudRate.SelectedItem.ToString()), this.GetParityValue(this.cboParity.SelectedItem.ToString()), int.Parse(this.cboDataBits.SelectedItem.ToString()), (StopBits)int.Parse(this.cboStopBit.SelectedItem.ToString()));
                this.MeterSerialPort.Open();
            }
        }

        private void CloseConnect()
        {
            this.secondsRemaining = 10;
            this.isRun = false;

            if (this.MeterSerialPort != null && this.MeterSerialPort.IsOpen)
            {
                this.MeterSerialPort.Close();
                this.MeterSerialPort = null;
            }

            if (this.intervalThread != null)
            {
                this.intervalThread.Abort();
                this.intervalThread.DisableComObjectEagerCleanup();
                this.intervalThread = null;
            }

            if (this.readThread != null)
            {
                this.readThread.Abort();
                this.readThread.DisableComObjectEagerCleanup();
                this.readThread = null;
            }
        }

        #region Thread Methods
        private void StartCountdown()
        {
            try
            {
                byte[] dataToSend;
                while (isRun)
                {
                    if (MeterSerialPort.IsOpen)
                    {
                        Thread.Sleep(1000);
                        this.secondsRemaining--;
                        this.txtIntervalTime.Invoke((MethodInvoker)delegate
                        {
                            txtIntervalTime.Text = secondsRemaining.ToString();
                        });

                        if (this.secondsRemaining == 0)
                        {
                            if (this.MeterSerialPort.IsOpen & this.MeterSerialPort != null)
                            {
                                dataToSend = Encoding.ASCII.GetBytes(this.strAutoCMD);
                                this.MeterSerialPort.Write(dataToSend, 0, dataToSend.Length);
                                this.txtMsgRefresh("Send Auto CMD:" + this.strAutoCMD.Replace("\r", ",").TrimEnd(','), REFRESHLOG.txtSendOutCMDLog);
                            }
                            this.secondsRemaining = 11;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.txtMsgRefresh(ex.Message, REFRESHLOG.txtMsgIntervalLog);
                this.CloseConnect();
                this.UIInitialize();
            }
        }
        private void ReadMeter()
        {
            int bytesToRead;
            byte[] buffer;
            string receiveData = string.Empty;
            string responseData = string.Empty;
            List<string> receiveList = new List<string>();
            List<string> responseList = new List<string>();
            try
            {
                while (isRun)
                {
                    if (MeterSerialPort.IsOpen)
                    {
                        Thread.Sleep(1000);
                        bytesToRead = MeterSerialPort.BytesToRead;
                        if (bytesToRead > 0)
                        {
                            buffer = new byte[bytesToRead];
                            MeterSerialPort.Read(buffer, 0, bytesToRead);
                            receiveData = ((System.Text.Encoding.Default.GetString(buffer)).Replace(">", "").Replace(@"EGRCCT ", ",").Replace(@"EGRL ", ",").Replace(@"EGRXYZ 0", ",").Replace(@"EGRYXY 0", ",")).Trim();
                            receiveList = receiveData.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                            foreach (string response in receiveList)
                            {
                                responseList = response.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToList();
                                if (responseList.Count > 1)
                                {
                                    if (responseList[0].ToString().Replace("\r\n", "").ToUpper() == "GRCCT")
                                        this.txtGRCCT.Invoke((MethodInvoker)delegate
                                        {
                                            this.txtGRCCT.Text = responseList[1].ToString();
                                        });
                                    if (responseList[0].ToString().Replace("\r\n", "").ToUpper() == "GRL")
                                        // 更新 UI 應在主線程中完成
                                        this.txtGRL.Invoke((MethodInvoker)delegate
                                        {
                                            this.txtGRL.Text = responseList[1].ToString();
                                        });
                                    if (responseList[0].ToString().Replace("\r\n", "").ToUpper() == "GRXYZ")
                                    {
                                        this.txtGRXYZ_X.Invoke((MethodInvoker)delegate
                                        {
                                            this.txtGRXYZ_X.Text = (responseList.Count > 1) ? responseList[1].ToString() : "x";
                                        });
                                        this.txtGRXYZ_Y.Invoke((MethodInvoker)delegate
                                        {
                                            this.txtGRXYZ_Y.Text = (responseList.Count > 2) ? responseList[2].ToString() : "y";
                                        });
                                        this.txtGRXYZ_Z.Invoke((MethodInvoker)delegate
                                        {
                                            this.txtGRXYZ_Z.Text = (responseList.Count > 3) ? responseList[3].ToString() : "z";
                                        });
                                    }
                                    if (responseList[0].ToString().Replace("\r\n", "").ToUpper() == "GRYXY")
                                    {
                                        this.txtGRYXY_Y1.Invoke((MethodInvoker)delegate
                                        {
                                            this.txtGRYXY_Y1.Text = (responseList.Count > 1) ? responseList[1].ToString() : "y";
                                        });
                                        this.txtGRYXY_X.Invoke((MethodInvoker)delegate
                                        {
                                            this.txtGRYXY_X.Text = (responseList.Count > 2) ? responseList[2].ToString() : "x";
                                        });
                                        this.txtGRYXY_Y2.Invoke((MethodInvoker)delegate
                                        {
                                            this.txtGRYXY_Y2.Text = (responseList.Count > 3) ? responseList[3].ToString() : "y";
                                        });
                                    }
                                }
                            }
                            this.txtMsgRefresh(receiveData.Replace("\r\n", ""), REFRESHLOG.txtMsgReceiveLog);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                this.txtMsgRefresh(ex.Message.ToString(), REFRESHLOG.txtMsgReceiveLog);
                this.CloseConnect();
                this.UIInitialize();
            }
            finally
            {
                receiveList = null;
                responseList = null;
                receiveData = string.Empty;
                responseData = string.Empty;
            }
        }
        #endregion

        private void watcher_EventArrived(object sender, EventArrivedEventArgs e)
        {
            if (this.cboPort.InvokeRequired)
            {
                this.cboPort.BeginInvoke(new Action<string>((msg) =>
                {
                    Thread.Sleep(1000);
                    List<string> tmpPortList = this.getDefaultConfigClass.GetPcPorts();
                    if (Convert.ToInt16(e.NewEvent.Properties["EventType"].Value) == 3)
                    {
                        if (!string.IsNullOrEmpty(this.strConnectPort) && (tmpPortList.Select(p => p.Split('-')[0].ToString().Trim().Contains(this.strConnectPort)).Count() < 0))
                        {
                            this.CloseConnect();
                            this.UIInitialize();
                        }
                    }
                    this.cboPort.Items.Clear();
                    if (tmpPortList.Count > 0)
                        this.cboPort.Items.AddRange(getDefaultConfigClass.GetPcPorts().ToArray().Length > 0 ? getDefaultConfigClass.GetPcPorts().ToArray() : new string[] { msg });
                    else
                        this.cboPort.Items.Add(msg);
                    this.cboPort.Text = (tmpPortList.Count > 0) ? tmpPortList[0] : msg;

                    if (this.cboPort.Text.Trim() == msg) this.btnTestConnect.Enabled = false; else this.btnPlay.Enabled = true;

                }), "Please Insert USB");
            }
            ManagementEventWatcher tmpWatcher = (ManagementEventWatcher)sender;
            tmpWatcher.Stop();
            Thread.Sleep(1000);
            tmpWatcher.Start();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.CloseConnect();
            this.watcher.Stop();
            this.watcher.Dispose();
        }
        #endregion
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

    public static class MetroComboBoxFactory
    {
        public static void CreateComboBoxDataChanged(MetroComboBox triggerComboBox, EventHandler txtChangedEvent)
        {
            if (triggerComboBox != null && txtChangedEvent != null)
            {
                triggerComboBox.TextChanged += txtChangedEvent;
            }
        }
    }
}
