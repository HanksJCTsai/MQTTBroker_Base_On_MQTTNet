using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
using FontAwesome.Sharp;
using MQTTBroker_Base_On_MQTTNet.ChildForms;

namespace MQTTBroker_Base_On_MQTTNet
{
    //https://www.youtube.com/watch?v=5AsJJl7Bhvc
    //https://rjcodeadvance.com/formulario-modernoiconos-font-awesome-winform-c/
    public partial class mainBroker : Form
    {
        //UI Fields
        private IconButton currentButn;
        private Panel leftBoarderBtn;
        private Form currentChildForm;
        public mainBroker()
        {
            InitializeComponent();
            leftBoarderBtn = new Panel();
            leftBoarderBtn.Size = new Size(7,60);
            panelMenu.Controls.Add(leftBoarderBtn);
            //Add Event
            this.btnDashboard.Click += new System.EventHandler(ClickEventButton);
            this.btnOrders.Click += new System.EventHandler(ClickEventButton);
            this.btnProducts.Click += new System.EventHandler(ClickEventButton);
            this.btnCustomers.Click += new System.EventHandler(ClickEventButton);
            this.btnMarketing.Click += new System.EventHandler(ClickEventButton);
            this.btnSetting.Click += new System.EventHandler(ClickEventButton);
            this.btnHome.Click += new System.EventHandler(ClickEventButton);
            this.btnExit.Click += new System.EventHandler(ClickEventPictureBox);
            this.btnMaximize.Click += new System.EventHandler(ClickEventPictureBox);
            this.btnMinimize.Click += new System.EventHandler(ClickEventPictureBox);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(MouseDownEvent);
            //Form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; 
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
        private void ActivateButton(object senderBtn, Color CurrentColor)
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
                iconCurrentChildForm.IconChar = currentButn.IconChar;
                iconCurrentChildForm.IconColor = CurrentColor;
                iconCurrentChildForm.IconFont = currentButn.IconFont;
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
                if (form.Name.Equals(childForm.Name))
                {
                    isFinded = true;
                    form.BringToFront();
                    form.Activate();
                    form.Focus();
                    childFormTitle = childForm.Text;
                    break;
                }
            }
            if (!isFinded)
            {
                panelDesktop.Controls.Add(childForm);
                panelDesktop.Tag = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                childForm.BringToFront();
                childForm.Show();
                childFormTitle = childForm.Text;
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
                    case "btnDashboard":
                        currentColor = RGBColors.color172;
                        //template = new DashboardForm();
                        template = new LightMeter.MainForm();
                        break;
                    case "btnOrders":
                        currentColor = RGBColors.color249;
                        template = (new OrdersForm());
                        break;
                    case "btnProducts":
                        currentColor = RGBColors.color253;
                        template = (new DashboardForm());
                        break;
                    case "btnCustomers":
                        currentColor = RGBColors.color95;
                        template = (new DashboardForm());
                        break;
                    case "btnMarketing":
                        currentColor = RGBColors.color24988;
                        template = (new DashboardForm());
                        break;
                    case "btnSetting":
                        currentColor = RGBColors.color24;
                        template = (new DashboardForm());
                        break;
                }

                if (((IconButton)sender).Name == "btnHome")
                {
                    //Reset
                    currentChildForm.Close();
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

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
         );


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
    }
}
