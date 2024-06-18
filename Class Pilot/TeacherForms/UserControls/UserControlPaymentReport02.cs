using Class_Pilot;
using Class_Pilot.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classpilot___PaymentReport02
{
    public partial class UserControlPaymentReport02 : UserControl
    {
        public UserControlPaymentReport02()
        {
            InitializeComponent();
            userControlPayRepPaidStudents1.Hide();
            userControlPayRepTotalEarnings1.Show();
            userControlPayRepUnpaidStudents1.Hide();
        }

        private void btnPaidStudents_Click(object sender, EventArgs e)
        {
            userControlPayRepPaidStudents1.Show();
            userControlPayRepTotalEarnings1.Hide();
            userControlPayRepUnpaidStudents1.Hide();

            btnPaidStudents.BackColor = Color.FromArgb(66, 126, 243);
            btnTotalEarnigns.BackColor = Color.FromArgb(31, 59, 115);
            btnUnpaidStudents.BackColor = Color.FromArgb(31, 59, 115);
        }

        private void btnUnpaidStudents_Click(object sender, EventArgs e)
        {
            userControlPayRepPaidStudents1.Hide();
            userControlPayRepTotalEarnings1.Hide();
            userControlPayRepUnpaidStudents1.Show();

            btnPaidStudents.BackColor = Color.FromArgb(31, 59, 115);
            btnTotalEarnigns.BackColor = Color.FromArgb(31, 59, 115);
            btnUnpaidStudents.BackColor = Color.FromArgb(66, 126, 243);
        }

        private void btnTotalEarnigns_Click(object sender, EventArgs e)
        {
            userControlPayRepPaidStudents1.Hide();
            userControlPayRepTotalEarnings1.Show();
            userControlPayRepUnpaidStudents1.Hide();

            btnPaidStudents.BackColor = Color.FromArgb(31, 59, 115);
            btnTotalEarnigns.BackColor = Color.FromArgb(66, 126, 243);
            btnUnpaidStudents.BackColor = Color.FromArgb(31, 59, 115);
        }

        private void UserControlPaymentReport02_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void userControlPayRepTotalEarnings1_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Create a new instance of the UserControl
            Teacher_PaymentDashboard userControl = new Teacher_PaymentDashboard();

            // Add the UserControl to the parent control of the current UserControl
            this.Parent.Controls.Add(userControl);

            // Show the UserControl and bring it to front
            userControl.Show();
            userControl.BringToFront();
            this.Hide();
        }
    }
}
