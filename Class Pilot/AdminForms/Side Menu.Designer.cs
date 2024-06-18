namespace Class_Pilot
{
    partial class AdminSideMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSideMenu));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnAttend = new System.Windows.Forms.Button();
            this.btnCreateClass = new System.Windows.Forms.Button();
            this.btnStdRegister = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnTutorEdit = new System.Windows.Forms.Button();
            this.StudentEditMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStudentEdit = new System.Windows.Forms.Button();
            this.btnStdEdit_AssignToClass = new System.Windows.Forms.Button();
            this.btnStdEdit_StdDetailsEdit = new System.Windows.Forms.Button();
            this.btnStdEditRemoveFromClass = new System.Windows.Forms.Button();
            this.btnTuteExamePaperSubmission = new System.Windows.Forms.Button();
            this.btnClassEdit = new System.Windows.Forms.Button();
            this.StuEditMenuTimer = new System.Windows.Forms.Timer(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            this.userControlStdEdit_StudentDetailsEdit1 = new Class_Pilot.UserControlStdEdit_StudentDetailsEdit();
            this.userControlStdEdit_RemoveFromClass1 = new Class_Pilot.UserControlStdEdit_RemoveFromClass();
            this.userControlClassEdit1 = new Class_Pilot.UserControlClassEdit();
            this.tute_ExamePaperSubmission1 = new Class_Pilot.Tute_ExamePaperSubmission();
            this.userControlStdEdit_AssignToClass1 = new Class_Pilot.UserControlStdEdit_AssignToClass();
            this.userControlTeacherEdit1 = new Class_Pilot.UserControlTeacherEdit();
            this.userControlPayments1 = new Class_Pilot.UserControlPayments();
            this.userControlStudentRegistration1 = new Class_Pilot.UserControlStudentRegistration();
            this.userControlReports1 = new Class_Pilot.UserControlReports();
            this.createClassUserControl1 = new Class_Pilot.CreateClassUserControl();
            this.attendance1 = new Class_Pilot.Attendance();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.StudentEditMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(83)))), ((int)(((byte)(113)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.btnAttend);
            this.flowLayoutPanel1.Controls.Add(this.btnCreateClass);
            this.flowLayoutPanel1.Controls.Add(this.btnStdRegister);
            this.flowLayoutPanel1.Controls.Add(this.btnPayments);
            this.flowLayoutPanel1.Controls.Add(this.btnReports);
            this.flowLayoutPanel1.Controls.Add(this.btnTutorEdit);
            this.flowLayoutPanel1.Controls.Add(this.StudentEditMenu);
            this.flowLayoutPanel1.Controls.Add(this.btnTuteExamePaperSubmission);
            this.flowLayoutPanel1.Controls.Add(this.btnClassEdit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(307, 907);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 91);
            this.panel1.TabIndex = 1;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeading.Location = new System.Drawing.Point(54, 21);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(184, 45);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Attendence";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAttend
            // 
            this.btnAttend.FlatAppearance.BorderSize = 0;
            this.btnAttend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttend.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAttend.ForeColor = System.Drawing.Color.White;
            this.btnAttend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttend.Location = new System.Drawing.Point(2, 97);
            this.btnAttend.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttend.Name = "btnAttend";
            this.btnAttend.Size = new System.Drawing.Size(304, 59);
            this.btnAttend.TabIndex = 2;
            this.btnAttend.Text = "ATTENDENCE";
            this.btnAttend.UseVisualStyleBackColor = true;
            this.btnAttend.Click += new System.EventHandler(this.btnAttend_Click);
            // 
            // btnCreateClass
            // 
            this.btnCreateClass.FlatAppearance.BorderSize = 0;
            this.btnCreateClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateClass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCreateClass.ForeColor = System.Drawing.Color.White;
            this.btnCreateClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateClass.Location = new System.Drawing.Point(2, 160);
            this.btnCreateClass.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateClass.Name = "btnCreateClass";
            this.btnCreateClass.Size = new System.Drawing.Size(304, 59);
            this.btnCreateClass.TabIndex = 3;
            this.btnCreateClass.Text = "CREATE CLASS";
            this.btnCreateClass.UseVisualStyleBackColor = true;
            this.btnCreateClass.Click += new System.EventHandler(this.btnCreateClass_Click);
            // 
            // btnStdRegister
            // 
            this.btnStdRegister.FlatAppearance.BorderSize = 0;
            this.btnStdRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStdRegister.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStdRegister.ForeColor = System.Drawing.Color.White;
            this.btnStdRegister.Location = new System.Drawing.Point(2, 223);
            this.btnStdRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnStdRegister.Name = "btnStdRegister";
            this.btnStdRegister.Size = new System.Drawing.Size(304, 59);
            this.btnStdRegister.TabIndex = 4;
            this.btnStdRegister.Text = "STUDENT REGISTER";
            this.btnStdRegister.UseVisualStyleBackColor = true;
            this.btnStdRegister.Click += new System.EventHandler(this.btnStdRegister_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.Location = new System.Drawing.Point(2, 286);
            this.btnPayments.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(304, 59);
            this.btnPayments.TabIndex = 5;
            this.btnPayments.Text = "PAYMENTS";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(2, 349);
            this.btnReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(304, 59);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "REPORTS";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnTutorEdit
            // 
            this.btnTutorEdit.FlatAppearance.BorderSize = 0;
            this.btnTutorEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutorEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTutorEdit.ForeColor = System.Drawing.Color.White;
            this.btnTutorEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTutorEdit.Location = new System.Drawing.Point(2, 412);
            this.btnTutorEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnTutorEdit.Name = "btnTutorEdit";
            this.btnTutorEdit.Size = new System.Drawing.Size(304, 59);
            this.btnTutorEdit.TabIndex = 7;
            this.btnTutorEdit.Text = "TUTOR EDIT";
            this.btnTutorEdit.UseVisualStyleBackColor = true;
            this.btnTutorEdit.Click += new System.EventHandler(this.btnTutorEdit_Click);
            // 
            // StudentEditMenu
            // 
            this.StudentEditMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(83)))), ((int)(((byte)(113)))));
            this.StudentEditMenu.Controls.Add(this.btnStudentEdit);
            this.StudentEditMenu.Controls.Add(this.btnStdEdit_AssignToClass);
            this.StudentEditMenu.Controls.Add(this.btnStdEdit_StdDetailsEdit);
            this.StudentEditMenu.Controls.Add(this.btnStdEditRemoveFromClass);
            this.StudentEditMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StudentEditMenu.Location = new System.Drawing.Point(2, 475);
            this.StudentEditMenu.Margin = new System.Windows.Forms.Padding(2);
            this.StudentEditMenu.MaximumSize = new System.Drawing.Size(304, 250);
            this.StudentEditMenu.MinimumSize = new System.Drawing.Size(304, 65);
            this.StudentEditMenu.Name = "StudentEditMenu";
            this.StudentEditMenu.Size = new System.Drawing.Size(304, 65);
            this.StudentEditMenu.TabIndex = 1;
            // 
            // btnStudentEdit
            // 
            this.btnStudentEdit.FlatAppearance.BorderSize = 0;
            this.btnStudentEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStudentEdit.ForeColor = System.Drawing.Color.White;
            this.btnStudentEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentEdit.Location = new System.Drawing.Point(2, 2);
            this.btnStudentEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnStudentEdit.Name = "btnStudentEdit";
            this.btnStudentEdit.Size = new System.Drawing.Size(304, 59);
            this.btnStudentEdit.TabIndex = 8;
            this.btnStudentEdit.Text = "STUDENT EDIT";
            this.btnStudentEdit.UseVisualStyleBackColor = true;
            this.btnStudentEdit.Click += new System.EventHandler(this.btnStudentEdit_Click);
            // 
            // btnStdEdit_AssignToClass
            // 
            this.btnStdEdit_AssignToClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.btnStdEdit_AssignToClass.FlatAppearance.BorderSize = 0;
            this.btnStdEdit_AssignToClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStdEdit_AssignToClass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStdEdit_AssignToClass.ForeColor = System.Drawing.Color.White;
            this.btnStdEdit_AssignToClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdEdit_AssignToClass.Location = new System.Drawing.Point(2, 65);
            this.btnStdEdit_AssignToClass.Margin = new System.Windows.Forms.Padding(2);
            this.btnStdEdit_AssignToClass.Name = "btnStdEdit_AssignToClass";
            this.btnStdEdit_AssignToClass.Size = new System.Drawing.Size(304, 59);
            this.btnStdEdit_AssignToClass.TabIndex = 10;
            this.btnStdEdit_AssignToClass.Text = "Assign to class";
            this.btnStdEdit_AssignToClass.UseVisualStyleBackColor = false;
            this.btnStdEdit_AssignToClass.Click += new System.EventHandler(this.btnStdEdit_AssignToClass_Click_1);
            // 
            // btnStdEdit_StdDetailsEdit
            // 
            this.btnStdEdit_StdDetailsEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.btnStdEdit_StdDetailsEdit.FlatAppearance.BorderSize = 0;
            this.btnStdEdit_StdDetailsEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStdEdit_StdDetailsEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStdEdit_StdDetailsEdit.ForeColor = System.Drawing.Color.White;
            this.btnStdEdit_StdDetailsEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdEdit_StdDetailsEdit.Location = new System.Drawing.Point(2, 128);
            this.btnStdEdit_StdDetailsEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnStdEdit_StdDetailsEdit.Name = "btnStdEdit_StdDetailsEdit";
            this.btnStdEdit_StdDetailsEdit.Size = new System.Drawing.Size(304, 50);
            this.btnStdEdit_StdDetailsEdit.TabIndex = 11;
            this.btnStdEdit_StdDetailsEdit.Text = "Student Details Edit";
            this.btnStdEdit_StdDetailsEdit.UseVisualStyleBackColor = false;
            this.btnStdEdit_StdDetailsEdit.Click += new System.EventHandler(this.btnStdEdit_StdDetailsEdit_Click);
            // 
            // btnStdEditRemoveFromClass
            // 
            this.btnStdEditRemoveFromClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.btnStdEditRemoveFromClass.FlatAppearance.BorderSize = 0;
            this.btnStdEditRemoveFromClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStdEditRemoveFromClass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStdEditRemoveFromClass.ForeColor = System.Drawing.Color.White;
            this.btnStdEditRemoveFromClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdEditRemoveFromClass.Location = new System.Drawing.Point(2, 182);
            this.btnStdEditRemoveFromClass.Margin = new System.Windows.Forms.Padding(2);
            this.btnStdEditRemoveFromClass.Name = "btnStdEditRemoveFromClass";
            this.btnStdEditRemoveFromClass.Size = new System.Drawing.Size(304, 50);
            this.btnStdEditRemoveFromClass.TabIndex = 12;
            this.btnStdEditRemoveFromClass.Text = "Remove From Class";
            this.btnStdEditRemoveFromClass.UseVisualStyleBackColor = false;
            this.btnStdEditRemoveFromClass.Click += new System.EventHandler(this.btnStdEditRemoveFromClass_Click);
            // 
            // btnTuteExamePaperSubmission
            // 
            this.btnTuteExamePaperSubmission.FlatAppearance.BorderSize = 0;
            this.btnTuteExamePaperSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuteExamePaperSubmission.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTuteExamePaperSubmission.ForeColor = System.Drawing.Color.White;
            this.btnTuteExamePaperSubmission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTuteExamePaperSubmission.Location = new System.Drawing.Point(2, 544);
            this.btnTuteExamePaperSubmission.Margin = new System.Windows.Forms.Padding(2);
            this.btnTuteExamePaperSubmission.Name = "btnTuteExamePaperSubmission";
            this.btnTuteExamePaperSubmission.Size = new System.Drawing.Size(304, 59);
            this.btnTuteExamePaperSubmission.TabIndex = 10;
            this.btnTuteExamePaperSubmission.Text = "TUTE/EXAM";
            this.btnTuteExamePaperSubmission.UseVisualStyleBackColor = true;
            this.btnTuteExamePaperSubmission.Click += new System.EventHandler(this.btnTuteExamePaperSubmission_Click);
            // 
            // btnClassEdit
            // 
            this.btnClassEdit.FlatAppearance.BorderSize = 0;
            this.btnClassEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClassEdit.ForeColor = System.Drawing.Color.White;
            this.btnClassEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClassEdit.Location = new System.Drawing.Point(2, 607);
            this.btnClassEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnClassEdit.Name = "btnClassEdit";
            this.btnClassEdit.Size = new System.Drawing.Size(304, 59);
            this.btnClassEdit.TabIndex = 9;
            this.btnClassEdit.Text = "CLASS EDIT";
            this.btnClassEdit.UseVisualStyleBackColor = true;
            this.btnClassEdit.Click += new System.EventHandler(this.btnClassEdit_Click);
            // 
            // StuEditMenuTimer
            // 
            this.StuEditMenuTimer.Interval = 10;
            this.StuEditMenuTimer.Tick += new System.EventHandler(this.StuEditMenuTimer_Tick);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(122)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::Class_Pilot.Properties.Resources.logout__1_;
            this.btnLogout.Location = new System.Drawing.Point(1619, 23);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(51, 52);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // userControlStdEdit_StudentDetailsEdit1
            // 
            this.userControlStdEdit_StudentDetailsEdit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.userControlStdEdit_StudentDetailsEdit1.Location = new System.Drawing.Point(311, 26);
            this.userControlStdEdit_StudentDetailsEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControlStdEdit_StudentDetailsEdit1.Name = "userControlStdEdit_StudentDetailsEdit1";
            this.userControlStdEdit_StudentDetailsEdit1.Size = new System.Drawing.Size(1394, 886);
            this.userControlStdEdit_StudentDetailsEdit1.TabIndex = 11;
            // 
            // userControlStdEdit_RemoveFromClass1
            // 
            this.userControlStdEdit_RemoveFromClass1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.userControlStdEdit_RemoveFromClass1.Location = new System.Drawing.Point(311, 2);
            this.userControlStdEdit_RemoveFromClass1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControlStdEdit_RemoveFromClass1.Name = "userControlStdEdit_RemoveFromClass1";
            this.userControlStdEdit_RemoveFromClass1.Size = new System.Drawing.Size(1394, 955);
            this.userControlStdEdit_RemoveFromClass1.TabIndex = 10;
            this.userControlStdEdit_RemoveFromClass1.Load += new System.EventHandler(this.userControlStdEdit_RemoveFromClass1_Load);
            // 
            // userControlClassEdit1
            // 
            this.userControlClassEdit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.userControlClassEdit1.Location = new System.Drawing.Point(312, 0);
            this.userControlClassEdit1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControlClassEdit1.Name = "userControlClassEdit1";
            this.userControlClassEdit1.Size = new System.Drawing.Size(1487, 917);
            this.userControlClassEdit1.TabIndex = 9;
            // 
            // tute_ExamePaperSubmission1
            // 
            this.tute_ExamePaperSubmission1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.tute_ExamePaperSubmission1.Location = new System.Drawing.Point(312, 0);
            this.tute_ExamePaperSubmission1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tute_ExamePaperSubmission1.Name = "tute_ExamePaperSubmission1";
            this.tute_ExamePaperSubmission1.Size = new System.Drawing.Size(1487, 917);
            this.tute_ExamePaperSubmission1.TabIndex = 8;
            // 
            // userControlStdEdit_AssignToClass1
            // 
            this.userControlStdEdit_AssignToClass1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.userControlStdEdit_AssignToClass1.Location = new System.Drawing.Point(312, 0);
            this.userControlStdEdit_AssignToClass1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControlStdEdit_AssignToClass1.Name = "userControlStdEdit_AssignToClass1";
            this.userControlStdEdit_AssignToClass1.Size = new System.Drawing.Size(1487, 917);
            this.userControlStdEdit_AssignToClass1.TabIndex = 7;
            // 
            // userControlTeacherEdit1
            // 
            this.userControlTeacherEdit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.userControlTeacherEdit1.Location = new System.Drawing.Point(312, 0);
            this.userControlTeacherEdit1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControlTeacherEdit1.Name = "userControlTeacherEdit1";
            this.userControlTeacherEdit1.Size = new System.Drawing.Size(1487, 917);
            this.userControlTeacherEdit1.TabIndex = 6;
            // 
            // userControlPayments1
            // 
            this.userControlPayments1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.userControlPayments1.Location = new System.Drawing.Point(312, 2);
            this.userControlPayments1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControlPayments1.Name = "userControlPayments1";
            this.userControlPayments1.Size = new System.Drawing.Size(1487, 917);
            this.userControlPayments1.TabIndex = 5;
            // 
            // userControlStudentRegistration1
            // 
            this.userControlStudentRegistration1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.userControlStudentRegistration1.Location = new System.Drawing.Point(312, 0);
            this.userControlStudentRegistration1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControlStudentRegistration1.Name = "userControlStudentRegistration1";
            this.userControlStudentRegistration1.Size = new System.Drawing.Size(1487, 917);
            this.userControlStudentRegistration1.TabIndex = 4;
            // 
            // userControlReports1
            // 
            this.userControlReports1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.userControlReports1.Location = new System.Drawing.Point(312, 0);
            this.userControlReports1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControlReports1.Name = "userControlReports1";
            this.userControlReports1.Size = new System.Drawing.Size(1487, 917);
            this.userControlReports1.TabIndex = 3;
            this.userControlReports1.Load += new System.EventHandler(this.userControlReports1_Load);
            // 
            // createClassUserControl1
            // 
            this.createClassUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.createClassUserControl1.Location = new System.Drawing.Point(312, 0);
            this.createClassUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createClassUserControl1.Name = "createClassUserControl1";
            this.createClassUserControl1.Size = new System.Drawing.Size(1487, 917);
            this.createClassUserControl1.TabIndex = 2;
            // 
            // attendance1
            // 
            this.attendance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.attendance1.Location = new System.Drawing.Point(312, 2);
            this.attendance1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.attendance1.Name = "attendance1";
            this.attendance1.Size = new System.Drawing.Size(1487, 917);
            this.attendance1.TabIndex = 1;
            // 
            // AdminSideMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(1792, 907);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.userControlStdEdit_StudentDetailsEdit1);
            this.Controls.Add(this.userControlStdEdit_RemoveFromClass1);
            this.Controls.Add(this.userControlClassEdit1);
            this.Controls.Add(this.tute_ExamePaperSubmission1);
            this.Controls.Add(this.userControlStdEdit_AssignToClass1);
            this.Controls.Add(this.userControlTeacherEdit1);
            this.Controls.Add(this.userControlPayments1);
            this.Controls.Add(this.userControlStudentRegistration1);
            this.Controls.Add(this.userControlReports1);
            this.Controls.Add(this.createClassUserControl1);
            this.Controls.Add(this.attendance1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1814, 963);
            this.MinimumSize = new System.Drawing.Size(1814, 963);
            this.Name = "AdminSideMenu";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Attendence_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.StudentEditMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnAttend;
        private System.Windows.Forms.Button btnCreateClass;
        private System.Windows.Forms.Button btnStdRegister;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnTutorEdit;
        private System.Windows.Forms.Button btnStudentEdit;
        private System.Windows.Forms.Button btnTuteExamePaperSubmission;
        private System.Windows.Forms.FlowLayoutPanel StudentEditMenu;
        private System.Windows.Forms.Button btnStdEdit_AssignToClass;
        private System.Windows.Forms.Timer StuEditMenuTimer;
        private System.Windows.Forms.Button btnStdEdit_StdDetailsEdit;
        private Attendance attendance1;
        private CreateClassUserControl createClassUserControl1;
        private UserControlReports userControlReports1;
        private UserControlStudentRegistration userControlStudentRegistration1;
        private UserControlPayments userControlPayments1;
        private UserControlTeacherEdit userControlTeacherEdit1;
        private System.Windows.Forms.Button btnClassEdit;
        private UserControlStdEdit_AssignToClass userControlStdEdit_AssignToClass1;
        private Tute_ExamePaperSubmission tute_ExamePaperSubmission1;
        private UserControlClassEdit userControlClassEdit1;
        private UserControlStdEdit_RemoveFromClass userControlStdEdit_RemoveFromClass1;
        private UserControlStdEdit_StudentDetailsEdit userControlStdEdit_StudentDetailsEdit1;
        private System.Windows.Forms.Button btnStdEditRemoveFromClass;
        private System.Windows.Forms.Button btnLogout;
    }
}