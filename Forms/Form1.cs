using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using dnts.Code;

namespace dnts
{
    public partial class frmLoadIn : Form
    {
        SeiyaMarx Design = new SeiyaMarx();
        public frmLoadIn()
        {
            InitializeComponent();
            Design.RoundCorners(this, 30);
        }

        private void frmLoadingWindow_Load(object sender, EventArgs e)
        {
            //frmLoginWindow frmLoginWindow = new frmLoginWindow();
            //frmLoginWindow.Show();
        }

        /* Program description and Requirements:
         * {
         *      1. Create a program that allows employees (user type: 2) to enter their time-in and time-out.
         *      2. Records must be accessible to Admin Level Users only (user type: 1), ALUs are able to check, modify and monitor the records,
         *         furthermore only the ALUs are able to add/remove employees (user type: 2).
         *      3. User Type 3 must be able to, request for an employee for a specific task or any form 
         *          of assitance that fits an employee's (user type: 2) skillset and responsibilities.
         *      4. User Type 3 or Clients should be able to communicate with Employees if deemed necessary.
         *      5. Upon creating a request for assitance, the Clients should be able to select a set of given choices of different types of assistance that the employees can offer.
         *      6. It should have a real-time display of available employees and should display the task an employee is currently doing if said employee is not available.
         * }
         * Client types' description and access limitations:
         * {
         *      1. Admin Level Users (TYPE 1):
         *          a. ALUs are capable of monitoring, managing and modifying employees and records.
         *          b. ALUs are capable of accepting or denying requests from clients.
         *          c. ALUs are capable of messaging other ALUs.
         *          d. ALUs can update the records, calendar, employee names, passwords and ID Number.
         *      2. Employees (TYPE 2):
         *          a. Type 2 are able to manage their own records and change their own passwords.
         *          b. They are able to add/remove any tasks or assitance that they may offer to clients.
         *          c. If the Employee is absent then he/she will not be displayed as an available employee in the requests page.
         *      3. Clients (TYPE 3):
         *          a. They will have an account made by ALUs, but they can change their passwords if they want to.
         *          b. They are able to request assitance from Employees by filling in a form of request, and is even able to request specific employees if said employee/s is/are available.
         *          c. Clients can directly send a message to ALUs.
         *          d. Clients have slightly different UI design compared to the Type 1, and Type 2.
         * }
         * Program UI Requirement:
         * {
         *      UI must vary for each user: type 1, type 2, type 3.
         *      UI of ALUs must have an inventory recording system of some form.
         *      All data should be in a database server.
         * }
         */
    }
}
