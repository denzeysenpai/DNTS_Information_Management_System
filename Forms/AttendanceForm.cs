using dnts.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnts.Forms
{
    public partial class AttendanceForm : Form
    {
        SeiyaMarx Design = new SeiyaMarx();
        bool notify, closeNotify, bounce;
        public AttendanceForm()
        {
            InitializeComponent();
            Design.RoundCorners(this, 30);
            Design.RoundCorners(pnlFrame1, 20);
            Design.RoundCorners(pnlFrame2, 20);
            Design.RoundCorners(pnlFrame3, 20);
            Design.RoundCorners(pnlTime, 16);
            Design.RoundCorners(pnlNotificationPanel, 48);
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            closeNotify = false;
            notify = false;
            bounce = true;
            pnlNotificationPanel.Left = Width;
        }

        private void testLogIn_Click(object sender, EventArgs e)
        {
            lblNotificationMessage.Text = "You have successfully logged in";
            notify = true;
        }

        private void testLogOut_Click(object sender, EventArgs e)
        {
            lblNotificationMessage.Text = "You have successfully logged out";
            notify = true;
        }


        readonly int LeftLimit = 1033;

        private void UI_Clock(object sender, EventArgs e)
        {
            DateTime timedate = DateTime.Now;

            String time_of_day = timedate.ToString("hh:mm:ss tt");

            lbl_time.Text = time_of_day;
        }

        int count = 0;
        private async void UI_Behavior(object sender, EventArgs e)
        {
            // NOTIFICATION PANEL

            // Notification panel left limit : 1033, 225

            if (notify && pnlNotificationPanel.Left > LeftLimit && bounce)
            {
                pnlNotificationPanel.Left -= 20;
            }


            if (notify && pnlNotificationPanel.Left < LeftLimit)
            {
                bounce = false;
                pnlNotificationPanel.Left += 2;
            }

            if (pnlNotificationPanel.Left < LeftLimit && notify && !bounce)
            {
                notify = false;
                closeNotify = true;
                bounce = true;
            }

            if (closeNotify && pnlNotificationPanel.Left > LeftLimit - 20 && bounce && count > 800)
                pnlNotificationPanel.Left -= 2;

            if (closeNotify && pnlNotificationPanel.Left < Width && count > 800)
                pnlNotificationPanel.Left += 20;

            if(closeNotify && pnlNotificationPanel.Left >= Width)
            {
                count = 0;
                bounce = true;
                closeNotify = false;
            }

            if(notify || closeNotify)
                count+= 5;
        }
    }
}
