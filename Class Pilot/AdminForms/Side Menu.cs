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

namespace Class_Pilot
{
    public partial class AdminSideMenu : Form
    {
        private bool StuEditCollapse = true;
        private const int AnimationIncrement = 10;
        private const int AnimationInterval = 5;
        public AdminSideMenu()
        {
            InitializeComponent();
        }

        private void StuEditMenuTimer_Tick(object sender, EventArgs e)
        {
            if (StuEditCollapse)
            {
                if (StudentEditMenu.Height < StudentEditMenu.MaximumSize.Height)
                {
                    StudentEditMenu.Height += AnimationIncrement;
                }
                else
                {
                    StuEditCollapse = false;
                    StuEditMenuTimer.Stop();
                }
            }
            else
            {
                if (StudentEditMenu.Height > StudentEditMenu.MinimumSize.Height)
                {
                    StudentEditMenu.Height -= AnimationIncrement;
                }
                else
                {
                    StuEditCollapse = true;
                    StuEditMenuTimer.Stop();
                }
            }
        }

        private void btnStudentEdit_Click(object sender, EventArgs e)
        {
            if (!StuEditMenuTimer.Enabled)
            {
                StuEditMenuTimer.Interval = AnimationInterval;
                StuEditMenuTimer.Start();
            }

        }

        

        private void btnAttend_Click(object sender, EventArgs e)
        {
            createClassUserControl1.Hide();
            attendance1.Show();
            userControlReports1.Hide();
            userControlStudentRegistration1.Hide();
            userControlPayments1.Hide();
            userControlTeacherEdit1.Hide();
            userControlStdEdit_AssignToClass1.Hide();
            tute_ExamePaperSubmission1.Hide();
            userControlClassEdit1.Hide();
            userControlStdEdit_RemoveFromClass1.Hide();
            userControlStdEdit_AssignToClass1.Hide();
            userControlStdEdit_StudentDetailsEdit1.Hide();

            lblHeading.Text = "Attendance";
            btnAttend.BackColor = Color.FromArgb(129, 139, 189);
            btnClassEdit.BackColor = Color.FromArgb(77, 83, 113);
            btnCreateClass.BackColor = Color.FromArgb(77, 83, 113);
            btnPayments.BackColor = Color.FromArgb(77, 83, 113);
            btnReports.BackColor = Color.FromArgb(77, 83, 113);
            btnStdRegister.BackColor = Color.FromArgb(77, 83, 113);
            btnStudentEdit.BackColor = Color.FromArgb(77, 83, 113);
            //btnTuteExamePaperSubmission = Color.FromArgb(77, 83, 113);
            btnTutorEdit.BackColor = Color.FromArgb(77, 83, 113);
        }

        private void btnCreateClass_Click(object sender, EventArgs e)
        {
            createClassUserControl1.Show();
            attendance1.Hide();
            userControlReports1.Hide();
            userControlStudentRegistration1.Hide();
            userControlPayments1.Hide();
            userControlTeacherEdit1.Hide();
            userControlStdEdit_AssignToClass1.Hide();
            tute_ExamePaperSubmission1.Hide();
            userControlClassEdit1.Hide();
            userControlStdEdit_RemoveFromClass1.Hide();
            userControlStdEdit_AssignToClass1.Hide();
            userControlStdEdit_StudentDetailsEdit1.Hide();

            lblHeading.Text = "Create Class";

            btnCreateClass.BackColor = Color.FromArgb(129, 139, 189);
            btnAttend.BackColor = Color.FromArgb(77, 83, 113);
            btnClassEdit.BackColor = Color.FromArgb(77, 83, 113);
            btnPayments.BackColor = Color.FromArgb(77, 83, 113);
            btnReports.BackColor = Color.FromArgb(77, 83, 113);
            btnStdRegister.BackColor = Color.FromArgb(77, 83, 113);
            btnStudentEdit.BackColor = Color.FromArgb(77, 83, 113);
            //btnTuteExamePaperSubmission = Color.FromArgb(77, 83, 113);
            btnTutorEdit.BackColor = Color.FromArgb(77, 83, 113);

        }

        private void userControlReports1_Load(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            createClassUserControl1.Hide();
            attendance1.Hide();
            userControlReports1.Show();
            userControlStudentRegistration1.Hide();
            userControlPayments1.Hide();
            userControlTeacherEdit1.Hide();
            userControlStdEdit_AssignToClass1.Hide();
            tute_ExamePaperSubmission1.Hide();
            userControlClassEdit1.Hide();
            userControlStdEdit_RemoveFromClass1.Hide();
            userControlStdEdit_AssignToClass1.Hide();
            userControlStdEdit_StudentDetailsEdit1.Hide();

            lblHeading.Text = "Reports";

            btnAttend.BackColor = Color.FromArgb(77, 83, 113);
            btnClassEdit.BackColor = Color.FromArgb(77, 83, 113);
            btnCreateClass.BackColor = Color.FromArgb(77, 83, 113);
            btnPayments.BackColor = Color.FromArgb(77, 83, 113);
            btnReports.BackColor = Color.FromArgb(129, 139, 189);
            btnStdRegister.BackColor = Color.FromArgb(77, 83, 113);
            btnStudentEdit.BackColor = Color.FromArgb(77, 83, 113);
            //btnTuteExamePaperSubmission = Color.FromArgb(77, 83, 113);
            btnTutorEdit.BackColor = Color.FromArgb(77, 83, 113);


        }

        private void btnStdRegister_Click(object sender, EventArgs e)
        {
            createClassUserControl1.Hide();
            attendance1.Hide();
            userControlReports1.Hide();
            userControlStudentRegistration1.Show();
            userControlPayments1.Hide();
            userControlTeacherEdit1.Hide();
            userControlStdEdit_AssignToClass1.Hide();
            tute_ExamePaperSubmission1.Hide();
            userControlClassEdit1.Hide();
            userControlStdEdit_RemoveFromClass1.Hide();
            userControlStdEdit_AssignToClass1.Hide();
            userControlStdEdit_StudentDetailsEdit1.Hide();

            lblHeading.Text = "Student Register";
            btnAttend.BackColor = Color.FromArgb(77, 83, 113);
            btnClassEdit.BackColor = Color.FromArgb(77, 83, 113);
            btnCreateClass.BackColor = Color.FromArgb(77, 83, 113);
            btnPayments.BackColor = Color.FromArgb(77, 83, 113);
            btnReports.BackColor = Color.FromArgb(77, 83, 113);
            btnStdRegister.BackColor = Color.FromArgb(129, 139, 189);
            btnStudentEdit.BackColor = Color.FromArgb(77, 83, 113);
            //btnTuteExamePaperSubmission = Color.FromArgb(77, 83, 113);
            btnTutorEdit.BackColor = Color.FromArgb(77, 83, 113);


        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            createClassUserControl1.Hide();
            attendance1.Hide();
            userControlReports1.Hide();
            userControlStudentRegistration1.Hide();
            userControlPayments1.Show();
            userControlTeacherEdit1.Hide();
            userControlStdEdit_AssignToClass1.Hide();
            tute_ExamePaperSubmission1.Hide();
            userControlClassEdit1.Hide();
            userControlStdEdit_RemoveFromClass1.Hide();
            userControlStdEdit_AssignToClass1.Hide();
            userControlStdEdit_StudentDetailsEdit1.Hide();

            lblHeading.Text = "Payments";
            btnAttend.BackColor = Color.FromArgb(77, 83, 113);
            btnClassEdit.BackColor = Color.FromArgb(77, 83, 113);
            btnCreateClass.BackColor = Color.FromArgb(77, 83, 113);
            btnPayments.BackColor = Color.FromArgb(129, 139, 189);
            btnReports.BackColor = Color.FromArgb(77, 83, 113);
            btnStdRegister.BackColor = Color.FromArgb(77, 83, 113);
            btnStudentEdit.BackColor = Color.FromArgb(77, 83, 113);
            //btnTuteExamePaperSubmission = Color.FromArgb(77, 83, 113);
            btnTutorEdit.BackColor = Color.FromArgb(77, 83, 113);
        }

        private void btnTutorEdit_Click(object sender, EventArgs e)
        {
            createClassUserControl1.Hide();
            attendance1.Hide();
            userControlReports1.Hide();
            userControlStudentRegistration1.Hide();
            userControlPayments1.Hide();
            userControlTeacherEdit1.Show();
            userControlStdEdit_AssignToClass1.Hide();
            tute_ExamePaperSubmission1.Hide();
            userControlClassEdit1.Hide();
            userControlStdEdit_RemoveFromClass1.Hide();
            userControlStdEdit_AssignToClass1.Hide();
            userControlStdEdit_StudentDetailsEdit1.Hide();

            lblHeading.Text = "Teacher Edit";
            btnAttend.BackColor = Color.FromArgb(77, 83, 113);
            btnClassEdit.BackColor = Color.FromArgb(77, 83, 113);
            btnCreateClass.BackColor = Color.FromArgb(77, 83, 113);
            btnPayments.BackColor = Color.FromArgb(77, 83, 113);
            btnReports.BackColor = Color.FromArgb(77, 83, 113);
            btnStdRegister.BackColor = Color.FromArgb(77, 83, 113);
            btnStudentEdit.BackColor = Color.FromArgb(77, 83, 113);
            //btnTuteExamePaperSubmission = Color.FromArgb(77, 83, 113);
            btnTutorEdit.BackColor = Color.FromArgb(129, 139, 189);
        }


        private void btnTuteExamePaperSubmission_Click(object sender, EventArgs e)
        {
            createClassUserControl1.Hide();
            attendance1.Hide();
            userControlReports1.Hide();
            userControlStudentRegistration1.Hide();
            userControlPayments1.Hide();
            userControlTeacherEdit1.Hide();
            userControlStdEdit_AssignToClass1.Hide();
            tute_ExamePaperSubmission1.Show();
            userControlClassEdit1.Hide();
            userControlStdEdit_RemoveFromClass1.Hide();
            userControlStdEdit_AssignToClass1.Hide();
            userControlStdEdit_StudentDetailsEdit1.Hide();

            lblHeading.Text = "Tute/Exam";
            btnAttend.BackColor = Color.FromArgb(77, 83, 113);
            btnClassEdit.BackColor = Color.FromArgb(77, 83, 113);
            btnCreateClass.BackColor = Color.FromArgb(77, 83, 113);
            btnPayments.BackColor = Color.FromArgb(77, 83, 113);
            btnReports.BackColor = Color.FromArgb(77, 83, 113);
            btnStdRegister.BackColor = Color.FromArgb(77, 83, 113);
            btnStudentEdit.BackColor = Color.FromArgb(77, 83, 113);
            //btnTuteExamePaperSubmission = Color.FromArgb(77, 83, 113);
            btnTutorEdit.BackColor = Color.FromArgb(77, 83, 113);
        }

        private void btnStdEdit_AssignToClass_Click(object sender, EventArgs e)
        {
            createClassUserControl1.Hide();
            attendance1.Hide();
            userControlReports1.Hide();
            userControlStudentRegistration1.Hide();
            userControlPayments1.Hide();
            userControlTeacherEdit1.Hide();
            userControlStdEdit_AssignToClass1.Hide();
            tute_ExamePaperSubmission1.Hide();
            userControlClassEdit1.Hide();
            userControlStdEdit_RemoveFromClass1.Hide();
            userControlStdEdit_AssignToClass1.Show();
            userControlStdEdit_StudentDetailsEdit1.Hide();

            lblHeading.Text = "Assign to Class";
        }

        private void btnClassEdit_Click(object sender, EventArgs e)
        {
            createClassUserControl1.Hide();
            attendance1.Hide();
            userControlReports1.Hide();
            userControlStudentRegistration1.Hide();
            userControlPayments1.Hide();
            userControlTeacherEdit1.Hide();
            userControlStdEdit_AssignToClass1.Hide();
            tute_ExamePaperSubmission1.Hide();
            userControlClassEdit1.Show();
            userControlStdEdit_RemoveFromClass1.Hide();
            userControlStdEdit_AssignToClass1.Hide();
            userControlStdEdit_StudentDetailsEdit1.Hide();

            lblHeading.Text = "Class Edit";
            btnAttend.BackColor = Color.FromArgb(77, 83, 113);
            btnClassEdit.BackColor = Color.FromArgb(129, 139, 189);
            btnCreateClass.BackColor = Color.FromArgb(77, 83, 113);
            btnPayments.BackColor = Color.FromArgb(77, 83, 113);
            btnReports.BackColor = Color.FromArgb(77, 83, 113);
            btnStdRegister.BackColor = Color.FromArgb(77, 83, 113);
            btnStudentEdit.BackColor = Color.FromArgb(77, 83, 113);
            //btnTuteExamePaperSubmission = Color.FromArgb(77, 83, 113);
            btnTutorEdit.BackColor = Color.FromArgb(77, 83, 113);
        }
        private void btnStdEdit_RemoveFromClass(object sender, EventArgs e)
        {

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {

        }

        private void Attendence_Load(object sender, EventArgs e)
        {
            lblHeading.Text = "";
        }

        private void btnStdEdit_AssignToClass_Click_1(object sender, EventArgs e)
        {
            createClassUserControl1.Hide();
            attendance1.Hide();
            userControlReports1.Hide();
            userControlStudentRegistration1.Hide();
            userControlPayments1.Hide();
            userControlTeacherEdit1.Hide();
            userControlStdEdit_AssignToClass1.Hide();
            tute_ExamePaperSubmission1.Hide();
            userControlClassEdit1.Hide();
            userControlStdEdit_RemoveFromClass1.Hide();
            userControlStdEdit_AssignToClass1.Show();
            userControlStdEdit_StudentDetailsEdit1.Hide();

            lblHeading.Text = "Assign to Class";
        }

        private void userControlStdEdit_RemoveFromClass1_Load(object sender, EventArgs e)
        {
     
        }

        private void btnStdEdit_StdDetailsEdit_Click(object sender, EventArgs e)
        {
            createClassUserControl1.Hide();
            attendance1.Hide();
            userControlReports1.Hide();
            userControlStudentRegistration1.Hide();
            userControlPayments1.Hide();
            userControlTeacherEdit1.Hide();
            userControlStdEdit_AssignToClass1.Hide();
            tute_ExamePaperSubmission1.Hide();
            userControlClassEdit1.Hide();
            userControlStdEdit_RemoveFromClass1.Hide();
            userControlStdEdit_AssignToClass1.Hide();
            userControlStdEdit_StudentDetailsEdit1.Show();

            lblHeading.Text = "Edit Student Details";
        }

        private void btnStdEditRemoveFromClass_Click(object sender, EventArgs e)
        {
            createClassUserControl1.Hide();
            attendance1.Hide();
            userControlReports1.Hide();
            userControlStudentRegistration1.Hide();
            userControlPayments1.Hide();
            userControlTeacherEdit1.Hide();
            userControlStdEdit_AssignToClass1.Hide();
            tute_ExamePaperSubmission1.Hide();
            userControlClassEdit1.Hide();
            userControlStdEdit_RemoveFromClass1.Show();
            userControlStdEdit_AssignToClass1.Hide();
            userControlStdEdit_StudentDetailsEdit1.Hide();

            lblHeading.Text = "Remove From Class";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           GeneralClasses generalClasses = new GeneralClasses();
            generalClasses.Logout(this);
        }
    }
}
