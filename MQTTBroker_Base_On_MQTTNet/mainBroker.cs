using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace MQTTBroker_Base_On_MQTTNet
{
    //https://www.youtube.com/watch?v=5AsJJl7Bhvc
    public partial class mainBroker : Form
    {
        //UI Fields
        private IconButton currentButn;
        private Panel leftBoarderBtn;
        public mainBroker()
        {
            InitializeComponent();
            leftBoarderBtn = new Panel();
            leftBoarderBtn.Size = new Size(7,60);
            panelMenu.Controls.Add(leftBoarderBtn);
            this.btnDashboard.Click += new System.EventHandler(this.ClickEventButton);
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
                currentButn = senderBtn as IconButton;
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
                currentButn.BringToFront();
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

        private void ClickEventButton(object sender, EventArgs e)
        {
           if (sender!= null)
            {
                ActivateButton(sender, RGBColors.color172);
            }
        }
    }
}
