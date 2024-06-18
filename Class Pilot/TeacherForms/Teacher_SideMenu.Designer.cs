namespace Class_Pilot { 
    partial class Teacher_SideMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher_SideMenu));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnMyClass = new System.Windows.Forms.Button();
            this.btnbtnPaymentReport = new System.Windows.Forms.Button();
            this.btnTuteExamInventory = new System.Windows.Forms.Button();
            this.btnStudentMarks = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnUserID = new System.Windows.Forms.Button();
            this.teacher_StudentMarksDashboard1 = new Teacher_Admin_Panel___Side_menu.Teacher_StudentMarksDashboard();
            this.tuteExamDashboard1 = new Class_Pilot.TeacherForms.UserControls.TuteExamDashboard();
            this.teacher_PaymentDashboard1 = new Class_Pilot.Teacher_PaymentDashboard();
            this.teacher_MyClassDashboard1 = new Classpilot___Myclass01.Teacher_MyClassDashboard();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(83)))), ((int)(((byte)(113)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.btnMyClass);
            this.flowLayoutPanel1.Controls.Add(this.btnbtnPaymentReport);
            this.flowLayoutPanel1.Controls.Add(this.btnTuteExamInventory);
            this.flowLayoutPanel1.Controls.Add(this.btnStudentMarks);
            this.flowLayoutPanel1.Controls.Add(this.btnLogin);
            this.flowLayoutPanel1.Controls.Add(this.btnUserID);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(307, 916);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
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
            this.lblHeading.Location = new System.Drawing.Point(9, 20);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(184, 45);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Attendence";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMyClass
            // 
            this.btnMyClass.FlatAppearance.BorderSize = 0;
            this.btnMyClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyClass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMyClass.ForeColor = System.Drawing.Color.White;
            this.btnMyClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyClass.Location = new System.Drawing.Point(2, 97);
            this.btnMyClass.Margin = new System.Windows.Forms.Padding(2);
            this.btnMyClass.Name = "btnMyClass";
            this.btnMyClass.Size = new System.Drawing.Size(304, 110);
            this.btnMyClass.TabIndex = 2;
            this.btnMyClass.Text = "MY CLASS";
            this.btnMyClass.UseVisualStyleBackColor = true;
            this.btnMyClass.Click += new System.EventHandler(this.btnMyClass_Click_1);
            // 
            // btnbtnPaymentReport
            // 
            this.btnbtnPaymentReport.FlatAppearance.BorderSize = 0;
            this.btnbtnPaymentReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbtnPaymentReport.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnbtnPaymentReport.ForeColor = System.Drawing.Color.White;
            this.btnbtnPaymentReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbtnPaymentReport.Location = new System.Drawing.Point(2, 211);
            this.btnbtnPaymentReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnbtnPaymentReport.Name = "btnbtnPaymentReport";
            this.btnbtnPaymentReport.Size = new System.Drawing.Size(304, 110);
            this.btnbtnPaymentReport.TabIndex = 3;
            this.btnbtnPaymentReport.Text = "PAYMENT REPORT";
            this.btnbtnPaymentReport.UseVisualStyleBackColor = true;
            this.btnbtnPaymentReport.Click += new System.EventHandler(this.btnbtnPaymentReport_Click);
            // 
            // btnTuteExamInventory
            // 
            this.btnTuteExamInventory.FlatAppearance.BorderSize = 0;
            this.btnTuteExamInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuteExamInventory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTuteExamInventory.ForeColor = System.Drawing.Color.White;
            this.btnTuteExamInventory.Location = new System.Drawing.Point(2, 325);
            this.btnTuteExamInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnTuteExamInventory.Name = "btnTuteExamInventory";
            this.btnTuteExamInventory.Size = new System.Drawing.Size(304, 110);
            this.btnTuteExamInventory.TabIndex = 4;
            this.btnTuteExamInventory.Text = "TUTE/EXAM INVENTORY";
            this.btnTuteExamInventory.UseVisualStyleBackColor = true;
            this.btnTuteExamInventory.Click += new System.EventHandler(this.btnTuteExamInventory_Click);
            // 
            // btnStudentMarks
            // 
            this.btnStudentMarks.FlatAppearance.BorderSize = 0;
            this.btnStudentMarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentMarks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStudentMarks.ForeColor = System.Drawing.Color.White;
            this.btnStudentMarks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentMarks.Location = new System.Drawing.Point(2, 439);
            this.btnStudentMarks.Margin = new System.Windows.Forms.Padding(2);
            this.btnStudentMarks.Name = "btnStudentMarks";
            this.btnStudentMarks.Size = new System.Drawing.Size(304, 110);
            this.btnStudentMarks.TabIndex = 5;
            this.btnStudentMarks.Text = "STUDENT MARKS";
            this.btnStudentMarks.UseVisualStyleBackColor = true;
            this.btnStudentMarks.Click += new System.EventHandler(this.btnStudentMarks_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(83)))), ((int)(((byte)(113)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLogin.ForeColor = System.Drawing.Color.Coral;
            this.btnLogin.Image = global::Class_Pilot.Properties.Resources.turn_off;
            this.btnLogin.Location = new System.Drawing.Point(3, 554);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(304, 90);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Log Out";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnUserID
            // 
            this.btnUserID.Enabled = false;
            this.btnUserID.FlatAppearance.BorderSize = 0;
            this.btnUserID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUserID.ForeColor = System.Drawing.Color.White;
            this.btnUserID.Location = new System.Drawing.Point(3, 650);
            this.btnUserID.Name = "btnUserID";
            this.btnUserID.Size = new System.Drawing.Size(304, 62);
            this.btnUserID.TabIndex = 7;
            this.btnUserID.UseVisualStyleBackColor = true;
            this.btnUserID.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // teacher_StudentMarksDashboard1
            // 
            this.teacher_StudentMarksDashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.teacher_StudentMarksDashboard1.Location = new System.Drawing.Point(354, 31);
            this.teacher_StudentMarksDashboard1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacher_StudentMarksDashboard1.Name = "teacher_StudentMarksDashboard1";
            this.teacher_StudentMarksDashboard1.Size = new System.Drawing.Size(1394, 955);
            this.teacher_StudentMarksDashboard1.TabIndex = 5;
            // 
            // tuteExamDashboard1
            // 
            this.tuteExamDashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.tuteExamDashboard1.Location = new System.Drawing.Point(354, 31);
            this.tuteExamDashboard1.Name = "tuteExamDashboard1";
            this.tuteExamDashboard1.Size = new System.Drawing.Size(1332, 885);
            this.tuteExamDashboard1.TabIndex = 4;
            // 
            // teacher_PaymentDashboard1
            // 
            this.teacher_PaymentDashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.teacher_PaymentDashboard1.Location = new System.Drawing.Point(414, 19);
            this.teacher_PaymentDashboard1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacher_PaymentDashboard1.Name = "teacher_PaymentDashboard1";
            this.teacher_PaymentDashboard1.Size = new System.Drawing.Size(1332, 885);
            this.teacher_PaymentDashboard1.TabIndex = 3;
            // 
            // teacher_MyClassDashboard1
            // 
            this.teacher_MyClassDashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.teacher_MyClassDashboard1.Location = new System.Drawing.Point(345, 19);
            this.teacher_MyClassDashboard1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacher_MyClassDashboard1.Name = "teacher_MyClassDashboard1";
            this.teacher_MyClassDashboard1.Size = new System.Drawing.Size(1332, 885);
            this.teacher_MyClassDashboard1.TabIndex = 2;
            // 
            // Teacher_SideMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(1796, 916);
            this.Controls.Add(this.teacher_StudentMarksDashboard1);
            this.Controls.Add(this.tuteExamDashboard1);
            this.Controls.Add(this.teacher_PaymentDashboard1);
            this.Controls.Add(this.teacher_MyClassDashboard1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1814, 961);
            this.Name = "Teacher_SideMenu";
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnMyClass;
        private System.Windows.Forms.Button btnbtnPaymentReport;
        private System.Windows.Forms.Button btnTuteExamInventory;
        private System.Windows.Forms.Button btnStudentMarks;
        private Classpilot___Myclass01.Teacher_MyClassDashboard teacher_MyClassDashboard1;
        private Teacher_PaymentDashboard teacher_PaymentDashboard1;
        private TeacherForms.UserControls.TuteExamDashboard tuteExamDashboard1;
        private Teacher_Admin_Panel___Side_menu.Teacher_StudentMarksDashboard teacher_StudentMarksDashboard1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnUserID;
    }
}

