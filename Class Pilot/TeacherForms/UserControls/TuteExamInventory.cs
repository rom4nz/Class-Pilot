using Class_Pilot.Classes;
using Class_Pilot.TeacherForms.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Pilot
{
    public partial class TuteExamInventory : UserControl
    {
        public TuteExamInventory()
        {
            InitializeComponent();
        }

        private void TuteExamInventory_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGivenTutes_Click(object sender, EventArgs e)
        {
            tuteExamInventory_TuteInventory1.Hide();
            tuteExamInventory_GivenTutes1.Show();

            btnGivenTutes.BackColor = Color.FromArgb(66, 126, 243);
            btnTuteInventory.BackColor = Color.FromArgb(31, 59, 115);
        }

        private void btnTuteInventory_Click(object sender, EventArgs e)
        {
            tuteExamInventory_TuteInventory1.Show();
            tuteExamInventory_GivenTutes1.Hide();

            btnGivenTutes.BackColor = Color.FromArgb(31, 59, 115);
            btnTuteInventory.BackColor = Color.FromArgb(66, 126, 243);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            // Create a new instance of the UserControl
            TuteExamDashboard userControl = new TuteExamDashboard();

            // Add the UserControl to the parent control of the current UserControl
            this.Parent.Controls.Add(userControl);

            // Show the UserControl and bring it to front
            userControl.Show();
            userControl.BringToFront();
            this.Hide();
            Global.classID = "0";
        }
    }
}
