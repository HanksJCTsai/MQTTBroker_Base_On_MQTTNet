using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
using FontAwesome.Sharp;
using MQTTBroker_Base_On_MQTTNet.ChildForms;

namespace MQTTBroker_Base_On_MQTTNet
{
    public partial class mainBroker : Form
    {
        private int borderSize = 2;
        //UI Fields
        private IconButton currentButn;
        private Panel leftBoarderBtn;
        private Form currentChildForm;
        public mainBroker()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(98, 102, 244);

            leftBoarderBtn = new Panel();
            leftBoarderBtn.Size = new Size(7,60);
            panelMenu.Controls.Add(leftBoarderBtn);
            //Add Event
            this.btnLightMeter.Click += new System.EventHandler(ClickEventButton);
            this.btnLightMeter.MouseLeave += new System.EventHandler(this.menuMouseLeaveEvent);
            this.btnLightMeter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuMouseMoveEvent);

            this.btnAPI.Click += new System.EventHandler(ClickEventButton);
            this.btnAPI.MouseLeave += new System.EventHandler(this.menuMouseLeaveEvent);
            this.btnAPI.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuMouseMoveEvent);

            this.btnHome.Click += new System.EventHandler(ClickEventButton);

            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);

            this.btnExit.Click += new System.EventHandler(ClickEventPictureBox);
            this.btnExit.MouseLeave += new System.EventHandler(this.controlBoxMouseLeaveEvent);
            this.btnExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlBoxMouseMoveEvent);

            this.btnMaximize.Click += new System.EventHandler(ClickEventPictureBox);
            this.btnMaximize.MouseLeave += new System.EventHandler(this.controlBoxMouseLeaveEvent);
            this.btnMaximize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlBoxMouseMoveEvent);

            this.btnMinimize.Click += new System.EventHandler(ClickEventPictureBox);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.controlBoxMouseLeaveEvent);
            this.btnMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.controlBoxMouseMoveEvent);
        }

        //Structs
        private struct RGBColors
        {
            public static Color color172 = Color.FromArgb(172, 126, 241);
            public static Color color249 = Color.FromArgb(249, 118, 176);
            public static Color color253 = Color.FromArgb(253, 138, 114);
            public static Color color95 = Color.FromArgb(95, 77, 221);
            public static Color color24988 = Color.FromArgb(249, 88, 155);
            public static Color color24 = Color.FromArgb(24, 161, 251);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color CurrentColor, bool mouseEvent = false)
        { 
            if(senderBtn != null)
            {
                DisableButton();
                //Button
                currentButn = (IconButton)senderBtn;
                currentButn.BackColor = Color.FromArgb(37,36,81);
                currentButn.ForeColor = CurrentColor;
                currentButn.IconColor = CurrentColor;
                currentButn.TextAlign = ContentAlignment.MiddleCenter;
                currentButn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButn.ImageAlign = ContentAlignment.MiddleRight;
                //Left board
                leftBoarderBtn.BackColor = CurrentColor;
                leftBoarderBtn.Location = new Point(0, currentButn.Location.Y);
                leftBoarderBtn.Visible = true;
                leftBoarderBtn.BringToFront();
                //Icon Title Child Form
                if (!mouseEvent)
                {
                    iconCurrentChildForm.IconChar = currentButn.IconChar;
                    iconCurrentChildForm.IconColor = CurrentColor;
                    iconCurrentChildForm.IconFont = currentButn.IconFont;
                }
            }
        }

        private void DisableButton()
        {
            if (currentButn != null)
            {
                currentButn.BackColor = Color.FromArgb(31, 30, 68);
                currentButn.ForeColor = Color.Gainsboro;
                currentButn.IconColor = Color.Gainsboro;
                currentButn.TextAlign = ContentAlignment.MiddleLeft;
                currentButn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            string childFormTitle = string.Empty;
            bool isFinded = false;
            foreach (Form form in panelDesktop.Controls)
            {
                if (form.Text.Equals(childForm.Text))
                {
                    isFinded = true;
                    childFormTitle = form.Text;
                    form.TopLevel = false;
                    form.BringToFront();
                    form.Activate();
                    form.Focus();
                    break;
                }
            }
            if (!isFinded)
            {
                childFormTitle = childForm.Text;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                childForm.TopLevel = false;
                childForm.Show();

                panelDesktop.Tag = childForm.Tag;
                panelDesktop.Controls.Add(childForm);

                childForm.BringToFront();
                childForm.Activate();
                childForm.Focus();
            }
            lblTitleChildForm.Text = childFormTitle;
        }

        private void ClickEventPictureBox(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Name == "btnExit")
            {
                Application.Exit();
            }
            if (((PictureBox)sender).Name == "btnMaximize")
            {
                if (WindowState == FormWindowState.Normal)
                    WindowState = FormWindowState.Maximized;
                else
                    WindowState = FormWindowState.Normal;
            }
            if (((PictureBox)sender).Name == "btnMinimize")
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void ClickEventButton(object sender, EventArgs e)
        {
           if (sender!= null)
            {
                Form template = new Form();
                Color currentColor = RGBColors.color172;
                switch (((IconButton)sender).Name)
                {
                    case "btnLightMeter":
                        currentColor = RGBColors.color172;
                        template = (new LightMeter.MainForm());
                        break;
                    case "btnAPI":
                        currentColor = RGBColors.color249;
                        template = (new APICommand.MainForm());
                        break;

                    case "btnProducts":
                        currentColor = RGBColors.color253;
                        break;
                    case "btnCustomers":
                        currentColor = RGBColors.color95;
                        break;
                    case "btnMarketing":
                        currentColor = RGBColors.color24988;
                        break;
                    case "btnSetting":
                        currentColor = RGBColors.color24;
                        break;
                }

                if (((IconButton)sender).Name == "btnHome")
                {
                    //Reset
                    foreach (Form form in panelDesktop.Controls)
                    {
                        form.Close();
                    }

                    DisableButton();
                    leftBoarderBtn.Visible = false;
                    iconCurrentChildForm.IconChar = IconChar.Home;
                    iconCurrentChildForm.IconColor = Color.MediumPurple;
                    lblTitleChildForm.Text = "Home";
                }
                else
                {
                    ActivateButton(sender, currentColor);
                }
                OpenChildForm(template);
            }
        }

        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
        //(
        //    int nLeftRect, // x-coordinate of upper-left corner
        //    int nTopRect, // y-coordinate of upper-left corner
        //    int nRightRect, // x-coordinate of lower-right corner
        //    int nBottomRect, // y-coordinate of lower-right corner
        //    int nWidthEllipse, // height of ellipse
        //    int nHeightEllipse // width of ellipse
        // );


        //Drag Form
        const int WM_NCLBUTTONDOWN = 0x112;
        const int HT_CAPTION = 0xf012;
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void MouseDownEvent(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        private void controlBoxMouseMoveEvent(object sender, MouseEventArgs e)
        {
            IconPictureBox iconBtn = (IconPictureBox)sender;
            iconBtn.Size = new Size(30, 30);
        }

        private void controlBoxMouseLeaveEvent(object sender, EventArgs e)
        {
            IconPictureBox iconBtn = (IconPictureBox)sender;
            iconBtn.Size = new Size(28, 28);
        }

        private void menuMouseMoveEvent(object sender, MouseEventArgs e)
        {
            Color currentColor = RGBColors.color172;
            switch (((IconButton)sender).Name)
            {
                case "btnLightMeter":
                    currentColor = RGBColors.color172;
                    break;
                case "btnAPI":
                    currentColor = RGBColors.color249;
                    break;
                case "btnProducts":
                    currentColor = RGBColors.color253;
                    break;
                case "btnCustomers":
                    currentColor = RGBColors.color95;
                    break;
                case "btnMarketing":
                    currentColor = RGBColors.color24988;
                    break;
                case "btnSetting":
                    currentColor = RGBColors.color24;
                    break;
            }
            ActivateButton(sender, currentColor, true);
        }
        //Event methods
        private void menuMouseLeaveEvent(object sender, EventArgs e)
        {
            DisableButton();
        }

        //Event methods
        private void mainBroker_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        //Private methods
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Normal:
                    //if (this.Padding.Top != borderSize)
                    this.Padding = new Padding(borderSize);
                break; 

                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 0, 8);
                break; 

                case FormWindowState.Minimized:
                    this.Padding = new Padding(0, 8, 0,8 );
                break;
            }
        }

        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1 )
            {
                return;
            }
            base.WndProc(ref m);
        }
    }
}
