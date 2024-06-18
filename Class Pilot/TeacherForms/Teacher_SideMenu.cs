using Class_Pilot.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Class_Pilot
{
    public partial class Teacher_SideMenu : Form
    {
        public Teacher_SideMenu()
        {
            InitializeComponent();
            btnUserID.ForeColor = Color.White;
            btnUserID.Text = $"Logged in ID: {Global.userID}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            teacher_MyClassDashboard1.Hide();
            teacher_PaymentDashboard1.Hide();
            tuteExamDashboard1.Hide();
            teacher_StudentMarksDashboard1.Hide();
            lblHeading.Text = "";


        }

        private void btnTutePaperInve_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
      

        }

        private void btnMyClass_Click(object sender, EventArgs e)
        {

           
        }

        private void teacher_MyClassDashboard1_Load(object sender, EventArgs e)
        {

        }

        private void btnPaymentReport_Click(object sender, EventArgs e)
        {
  
           
        }

        private void btnMyClass_Click_1(object sender, EventArgs e)
        {
            teacher_MyClassDashboard1.Show();
            teacher_PaymentDashboard1.Hide();
            tuteExamDashboard1.Hide();
            teacher_StudentMarksDashboard1.Hide();
            lblHeading.Text = "My Class";
            btnMyClass.BackColor = Color.FromArgb(129, 139, 189);
            btnbtnPaymentReport.BackColor = Color.FromArgb(77, 83, 113);
            btnStudentMarks.BackColor = Color.FromArgb(77, 83, 113);
            btnTuteExamInventory.BackColor = Color.FromArgb(77, 83, 113);

        }

        private void btnbtnPaymentReport_Click(object sender, EventArgs e)
        {
            teacher_MyClassDashboard1.Hide();
            teacher_PaymentDashboard1.Show();
            tuteExamDashboard1.Hide();
            teacher_StudentMarksDashboard1.Hide();

            lblHeading.Text = "Payment Report";
            btnMyClass.BackColor = Color.FromArgb(77, 83, 113);
            btnbtnPaymentReport.BackColor = Color.FromArgb(129, 139, 189);
            btnStudentMarks.BackColor = Color.FromArgb(77, 83, 113);
            btnTuteExamInventory.BackColor = Color.FromArgb(77, 83, 113);
        }

        private void btnTuteExamInventory_Click(object sender, EventArgs e)
        {
            teacher_MyClassDashboard1.Hide();
            teacher_PaymentDashboard1.Hide();
            tuteExamDashboard1.Show();
            teacher_StudentMarksDashboard1.Hide();

            lblHeading.Text = "Inventory";
            btnMyClass.BackColor = Color.FromArgb(77, 83, 113);
            btnbtnPaymentReport.BackColor = Color.FromArgb(77, 83, 113);
            btnStudentMarks.BackColor = Color.FromArgb(77, 83, 113);
            btnTuteExamInventory.BackColor = Color.FromArgb(129, 139, 189);

        }

        private void btnStudentMarks_Click(object sender, EventArgs e)
        {
            teacher_MyClassDashboard1.Hide();
            teacher_PaymentDashboard1.Hide();
            tuteExamDashboard1.Hide();
            teacher_StudentMarksDashboard1.Show();

            lblHeading.Text = "Student Marks";
            btnMyClass.BackColor = Color.FromArgb(77, 83, 113);
            btnbtnPaymentReport.BackColor = Color.FromArgb(77, 83, 113);
            btnStudentMarks.BackColor = Color.FromArgb(129, 139, 189);
            btnTuteExamInventory.BackColor = Color.FromArgb(77, 83, 113);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GeneralClasses generalClasses = new GeneralClasses();
            generalClasses.Logout(this);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
