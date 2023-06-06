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

namespace dnts
{
    public partial class UIForALUs : Form
    {
        // panel size : 1118, 648

        // panel location : 218, 77

        // move loc = 0, 0, 433
        // move from = 0, 283

        bool MoveAccountsPanel;
        Point inView = new Point(215, 71);
        Point removeFromView = new Point(1336,71);

        SeiyaMarx Design = new SeiyaMarx();
        public UIForALUs()
        {
            InitializeComponent();
            Design.RoundCorners(this, 30);
            Design.RoundCorners(pnlMenuPanels, 20);
            Design.RoundCorners(pnlFrame1, 20);
            Design.RoundCorners(btnAccounts, 20);
            Design.RoundCorners(pnlFrame3, 20);
            Design.RoundCorners(pnlFrame4, 20);
            Design.RoundCorners(pnlMenuBorder, 21);

            Design.RoundCorners(pnlFrameA1, 20);
            Design.RoundCorners(pnlFrameA2, 20);
            Design.RoundCorners(pnlFrameA3, 20);
            Design.RoundCorners(pnlFrameA4, 20);
            Design.RoundCorners(pnlFrameA5, 20);
        }

        private void UIForALUs_Load(object sender, EventArgs e)
        {
            MoveAccountsPanel = false;
            pnlMove.Location = new Point(0, 283);
            pnlMenuBorder.BackColor = Color.FromArgb(179, 226, 255);
        }

        private void UIChecker(object sender, EventArgs e)
        {

        }

        private void btnAccounts_Click(object sender, EventArgs e) => MoveAccountsPanel = true;
        private void Lv1(object sender, EventArgs e) => MoveAccountsPanel = false;
        private void In2(object sender, EventArgs e) => MoveAccountsPanel = true;
        private void Lv2(object sender, EventArgs e) => MoveAccountsPanel = false;

        private void AnimateStuff(object sender, EventArgs e)
        {
            if (MoveAccountsPanel == true && pnlMove.Top < 433) 
            {
                pnlMove.Top += 10;
            }

            if (MoveAccountsPanel == false && pnlMove.Top > 283)
            {
                pnlMove.Top -= 5;
            }
        }

        private void btnGoToDashboard_Click(object sender, EventArgs e)
        {
            pnlAdmins.Hide();
            pnlAdmins.Location = removeFromView;
            pnlAdmins.Enabled = !true;

            pnlDashBoard.Show();
            pnlDashBoard.Location = inView;
            pnlDashBoard.Enabled = true;
        }

        private void btnAdmins_Click(object sender, EventArgs e)
        {
            pnlDashBoard.Hide();
            pnlDashBoard.Location = removeFromView;
            pnlDashBoard.Enabled = !true;

            pnlAdmins.Show();
            pnlAdmins.Location = inView;
            pnlAdmins.Enabled = true;
        }
    }
}
