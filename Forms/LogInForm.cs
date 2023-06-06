using dnts.Code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace dnts.Forms
{
    public partial class LogInForm : Form
    {
        SeiyaMarx Design = new SeiyaMarx();
        public LogInForm()
        {
            InitializeComponent();
            Design.RoundCorners(pnlLogInPanel, 40);
            Design.RoundCorners(this, 30);
            Design.RoundCorners(pnlUserName, 25);
            Design.RoundCorners(borderUsername, 25);
            Design.RoundCorners(pnlPassWord, 25);
            Design.RoundCorners(borderPassWord, 25);


        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            pcbShownToHidden.Hide();
        }

        private void UI_Assistant(object sender, EventArgs e)
        {

            if (txtUserName.Focused == true)
            {
                borderUsername.BackColor = Color.FromArgb(87, 185, 247);
                lblUserName.Hide();
            }
            else
            {
                borderUsername.BackColor = Color.White;
                lblUserName.Show();
            }


            if (txtPassWord.Focused == true)
            {
                borderPassWord.BackColor = Color.FromArgb(87, 185, 247);
                lblPassWord.Hide();
            }
            else
            {
                borderPassWord.BackColor = Color.White;
                lblPassWord.Show();
            }

        }

        private void UserNameTextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text != null && txtUserName.Text != string.Empty)
            {
                lblUserName.SendToBack();
            }
            else
                lblUserName.BringToFront();
        }

        private void HidePassword(object sender, EventArgs e)
        {
            txtPassWord.UseSystemPasswordChar = true;
            pcbShownToHidden.Hide();
            pcbHiddenToShow.Show();

        }

        private void ShowPassword(object sender, EventArgs e)
        {
            txtPassWord.UseSystemPasswordChar = false;
            pcbHiddenToShow.Hide();
            pcbShownToHidden.Show();

        }

        private void PassWordTextChanged(object sender, EventArgs e)
        {
            if (txtPassWord.Text != null && txtPassWord.Text != string.Empty)
            {
                lblPassWord.SendToBack();
            }
            else
                lblPassWord.BringToFront();
        }
    }
}
