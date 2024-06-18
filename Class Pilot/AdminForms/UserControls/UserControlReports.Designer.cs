namespace Class_Pilot
{
    partial class UserControlReports
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel18 = new System.Windows.Forms.Panel();
            this.pnlSel = new System.Windows.Forms.Panel();
            this.ButtonStudR = new System.Windows.Forms.Button();
            this.ButtonTeachR = new System.Windows.Forms.Button();
            this.userControlStudent1 = new Class_Pilot.UserControls.UserControlStudent();
            this.userControlTeacher1 = new Class_Pilot.UserControls.UserControlTeacher();
            this.SuspendLayout();
            // 
            // panel18
            // 
            this.panel18.AutoSize = true;
            this.panel18.BackColor = System.Drawing.Color.White;
            this.panel18.Location = new System.Drawing.Point(4, 168);
            this.panel18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1275, 2);
            this.panel18.TabIndex = 57;
            this.panel18.Paint += new System.Windows.Forms.PaintEventHandler(this.panel18_Paint);
            // 
            // pnlSel
            // 
            this.pnlSel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(122)))));
            this.pnlSel.Location = new System.Drawing.Point(273, 155);
            this.pnlSel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSel.Name = "pnlSel";
            this.pnlSel.Size = new System.Drawing.Size(252, 10);
            this.pnlSel.TabIndex = 60;
            this.pnlSel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSel_Paint);
            // 
            // ButtonStudR
            // 
            this.ButtonStudR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.ButtonStudR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStudR.FlatAppearance.BorderSize = 0;
            this.ButtonStudR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStudR.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStudR.ForeColor = System.Drawing.Color.White;
            this.ButtonStudR.Location = new System.Drawing.Point(642, 85);
            this.ButtonStudR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonStudR.Name = "ButtonStudR";
            this.ButtonStudR.Size = new System.Drawing.Size(409, 85);
            this.ButtonStudR.TabIndex = 59;
            this.ButtonStudR.Text = "Student Report";
            this.ButtonStudR.UseVisualStyleBackColor = false;
            this.ButtonStudR.Click += new System.EventHandler(this.ButtonStudR_Click);
            // 
            // ButtonTeachR
            // 
            this.ButtonTeachR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.ButtonTeachR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonTeachR.FlatAppearance.BorderSize = 0;
            this.ButtonTeachR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTeachR.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTeachR.ForeColor = System.Drawing.Color.White;
            this.ButtonTeachR.Location = new System.Drawing.Point(200, 85);
            this.ButtonTeachR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonTeachR.Name = "ButtonTeachR";
            this.ButtonTeachR.Size = new System.Drawing.Size(409, 85);
            this.ButtonTeachR.TabIndex = 58;
            this.ButtonTeachR.Text = "Teacher Report";
            this.ButtonTeachR.UseVisualStyleBackColor = false;
            this.ButtonTeachR.Click += new System.EventHandler(this.ButtonTeachR_Click);
            // 
            // userControlStudent1
            // 
            this.userControlStudent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.userControlStudent1.Location = new System.Drawing.Point(88, 180);
            this.userControlStudent1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControlStudent1.Name = "userControlStudent1";
            this.userControlStudent1.Size = new System.Drawing.Size(1225, 755);
            this.userControlStudent1.TabIndex = 62;
            // 
            // userControlTeacher1
            // 
            this.userControlTeacher1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.userControlTeacher1.Location = new System.Drawing.Point(90, 195);
            this.userControlTeacher1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControlTeacher1.Name = "userControlTeacher1";
            this.userControlTeacher1.Size = new System.Drawing.Size(1225, 755);
            this.userControlTeacher1.TabIndex = 61;
            // 
            // UserControlReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.userControlStudent1);
            this.Controls.Add(this.userControlTeacher1);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.pnlSel);
            this.Controls.Add(this.ButtonStudR);
            this.Controls.Add(this.ButtonTeachR);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlReports";
            this.Size = new System.Drawing.Size(1394, 955);
            this.Load += new System.EventHandler(this.UserControlReports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel pnlSel;
        private System.Windows.Forms.Button ButtonStudR;
        private System.Windows.Forms.Button ButtonTeachR;
        private UserControls.UserControlTeacher userControlTeacher1;
        private UserControls.UserControlStudent userControlStudent1;
    }
}
