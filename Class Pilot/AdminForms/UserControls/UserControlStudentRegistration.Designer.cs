namespace Class_Pilot
{
    partial class UserControlStudentRegistration
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
            this.stddatetimepickerDOB = new System.Windows.Forms.DateTimePicker();
            this.lblstdDOB = new System.Windows.Forms.Label();
            this.rbtnstdFemale = new System.Windows.Forms.RadioButton();
            this.rbtnstdMale = new System.Windows.Forms.RadioButton();
            this.lblstdGender = new System.Windows.Forms.Label();
            this.txtstdPhoneNo = new System.Windows.Forms.TextBox();
            this.lblstdaddress = new System.Windows.Forms.Label();
            this.txtstdAddress = new System.Windows.Forms.TextBox();
            this.lblstdPhoneNumber = new System.Windows.Forms.Label();
            this.txtstdLastName = new System.Windows.Forms.TextBox();
            this.lblstdLastName = new System.Windows.Forms.Label();
            this.txtstdFirstName = new System.Windows.Forms.TextBox();
            this.lblstdFirstName = new System.Windows.Forms.Label();
            this.lblstdID = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChImage = new System.Windows.Forms.Button();
            this.txtImageLocation = new System.Windows.Forms.TextBox();
            this.txtStdID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stddatetimepickerDOB
            // 
            this.stddatetimepickerDOB.CalendarFont = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stddatetimepickerDOB.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.stddatetimepickerDOB.CustomFormat = "dd-MM-yyyy";
            this.stddatetimepickerDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stddatetimepickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.stddatetimepickerDOB.Location = new System.Drawing.Point(295, 710);
            this.stddatetimepickerDOB.Margin = new System.Windows.Forms.Padding(2);
            this.stddatetimepickerDOB.Name = "stddatetimepickerDOB";
            this.stddatetimepickerDOB.Size = new System.Drawing.Size(266, 35);
            this.stddatetimepickerDOB.TabIndex = 51;
            // 
            // lblstdDOB
            // 
            this.lblstdDOB.AutoSize = true;
            this.lblstdDOB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstdDOB.ForeColor = System.Drawing.Color.White;
            this.lblstdDOB.Location = new System.Drawing.Point(112, 718);
            this.lblstdDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstdDOB.Name = "lblstdDOB";
            this.lblstdDOB.Size = new System.Drawing.Size(141, 29);
            this.lblstdDOB.TabIndex = 50;
            this.lblstdDOB.Text = "Date Of Birth";
            // 
            // rbtnstdFemale
            // 
            this.rbtnstdFemale.AutoSize = true;
            this.rbtnstdFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnstdFemale.ForeColor = System.Drawing.Color.LightGray;
            this.rbtnstdFemale.Location = new System.Drawing.Point(465, 608);
            this.rbtnstdFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnstdFemale.Name = "rbtnstdFemale";
            this.rbtnstdFemale.Size = new System.Drawing.Size(120, 33);
            this.rbtnstdFemale.TabIndex = 49;
            this.rbtnstdFemale.TabStop = true;
            this.rbtnstdFemale.Text = "Female";
            this.rbtnstdFemale.UseVisualStyleBackColor = true;
            this.rbtnstdFemale.CheckedChanged += new System.EventHandler(this.rbtnstdFemale_CheckedChanged);
            // 
            // rbtnstdMale
            // 
            this.rbtnstdMale.AutoSize = true;
            this.rbtnstdMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnstdMale.ForeColor = System.Drawing.Color.LightGray;
            this.rbtnstdMale.Location = new System.Drawing.Point(295, 608);
            this.rbtnstdMale.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnstdMale.Name = "rbtnstdMale";
            this.rbtnstdMale.Size = new System.Drawing.Size(91, 33);
            this.rbtnstdMale.TabIndex = 48;
            this.rbtnstdMale.TabStop = true;
            this.rbtnstdMale.Text = "Male";
            this.rbtnstdMale.UseVisualStyleBackColor = true;
            this.rbtnstdMale.CheckedChanged += new System.EventHandler(this.rbtnstdMale_CheckedChanged);
            // 
            // lblstdGender
            // 
            this.lblstdGender.AutoSize = true;
            this.lblstdGender.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstdGender.ForeColor = System.Drawing.Color.White;
            this.lblstdGender.Location = new System.Drawing.Point(111, 605);
            this.lblstdGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstdGender.Name = "lblstdGender";
            this.lblstdGender.Size = new System.Drawing.Size(86, 29);
            this.lblstdGender.TabIndex = 47;
            this.lblstdGender.Text = "Gender";
            // 
            // txtstdPhoneNo
            // 
            this.txtstdPhoneNo.BackColor = System.Drawing.Color.White;
            this.txtstdPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstdPhoneNo.ForeColor = System.Drawing.Color.Black;
            this.txtstdPhoneNo.Location = new System.Drawing.Point(295, 389);
            this.txtstdPhoneNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtstdPhoneNo.Name = "txtstdPhoneNo";
            this.txtstdPhoneNo.Size = new System.Drawing.Size(473, 35);
            this.txtstdPhoneNo.TabIndex = 46;
            // 
            // lblstdaddress
            // 
            this.lblstdaddress.AutoSize = true;
            this.lblstdaddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstdaddress.ForeColor = System.Drawing.Color.White;
            this.lblstdaddress.Location = new System.Drawing.Point(99, 479);
            this.lblstdaddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstdaddress.Name = "lblstdaddress";
            this.lblstdaddress.Size = new System.Drawing.Size(91, 29);
            this.lblstdaddress.TabIndex = 45;
            this.lblstdaddress.Text = "Address";
            // 
            // txtstdAddress
            // 
            this.txtstdAddress.BackColor = System.Drawing.Color.White;
            this.txtstdAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstdAddress.ForeColor = System.Drawing.Color.Black;
            this.txtstdAddress.Location = new System.Drawing.Point(295, 479);
            this.txtstdAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtstdAddress.Multiline = true;
            this.txtstdAddress.Name = "txtstdAddress";
            this.txtstdAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtstdAddress.Size = new System.Drawing.Size(473, 89);
            this.txtstdAddress.TabIndex = 44;
            // 
            // lblstdPhoneNumber
            // 
            this.lblstdPhoneNumber.AutoSize = true;
            this.lblstdPhoneNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstdPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblstdPhoneNumber.Location = new System.Drawing.Point(102, 392);
            this.lblstdPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstdPhoneNumber.Name = "lblstdPhoneNumber";
            this.lblstdPhoneNumber.Size = new System.Drawing.Size(162, 29);
            this.lblstdPhoneNumber.TabIndex = 43;
            this.lblstdPhoneNumber.Text = "Phone Number";
            // 
            // txtstdLastName
            // 
            this.txtstdLastName.BackColor = System.Drawing.Color.White;
            this.txtstdLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstdLastName.ForeColor = System.Drawing.Color.Black;
            this.txtstdLastName.Location = new System.Drawing.Point(295, 295);
            this.txtstdLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtstdLastName.Name = "txtstdLastName";
            this.txtstdLastName.Size = new System.Drawing.Size(473, 35);
            this.txtstdLastName.TabIndex = 42;
            // 
            // lblstdLastName
            // 
            this.lblstdLastName.AutoSize = true;
            this.lblstdLastName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstdLastName.ForeColor = System.Drawing.Color.White;
            this.lblstdLastName.Location = new System.Drawing.Point(99, 284);
            this.lblstdLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstdLastName.Name = "lblstdLastName";
            this.lblstdLastName.Size = new System.Drawing.Size(116, 29);
            this.lblstdLastName.TabIndex = 41;
            this.lblstdLastName.Text = "Last Name";
            // 
            // txtstdFirstName
            // 
            this.txtstdFirstName.BackColor = System.Drawing.Color.White;
            this.txtstdFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstdFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtstdFirstName.Location = new System.Drawing.Point(295, 196);
            this.txtstdFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtstdFirstName.Name = "txtstdFirstName";
            this.txtstdFirstName.Size = new System.Drawing.Size(473, 35);
            this.txtstdFirstName.TabIndex = 40;
            // 
            // lblstdFirstName
            // 
            this.lblstdFirstName.AutoSize = true;
            this.lblstdFirstName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstdFirstName.ForeColor = System.Drawing.Color.White;
            this.lblstdFirstName.Location = new System.Drawing.Point(102, 196);
            this.lblstdFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstdFirstName.Name = "lblstdFirstName";
            this.lblstdFirstName.Size = new System.Drawing.Size(119, 29);
            this.lblstdFirstName.TabIndex = 39;
            this.lblstdFirstName.Text = "First Name";
            // 
            // lblstdID
            // 
            this.lblstdID.AutoSize = true;
            this.lblstdID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstdID.ForeColor = System.Drawing.Color.White;
            this.lblstdID.Location = new System.Drawing.Point(102, 102);
            this.lblstdID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstdID.Name = "lblstdID";
            this.lblstdID.Size = new System.Drawing.Size(117, 29);
            this.lblstdID.TabIndex = 37;
            this.lblstdID.Text = "Student ID";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SaddleBrown;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1044, 705);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 42);
            this.button2.TabIndex = 71;
            this.button2.Text = "Clear";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1044, 622);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 42);
            this.button1.TabIndex = 70;
            this.button1.Text = "Register";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(989, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // btnChImage
            // 
            this.btnChImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.btnChImage.FlatAppearance.BorderSize = 0;
            this.btnChImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(122)))));
            this.btnChImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChImage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChImage.ForeColor = System.Drawing.Color.White;
            this.btnChImage.Location = new System.Drawing.Point(1018, 360);
            this.btnChImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChImage.Name = "btnChImage";
            this.btnChImage.Size = new System.Drawing.Size(228, 62);
            this.btnChImage.TabIndex = 73;
            this.btnChImage.Text = "Choose Image";
            this.btnChImage.UseVisualStyleBackColor = false;
            this.btnChImage.Click += new System.EventHandler(this.btnChImage_Click);
            // 
            // txtImageLocation
            // 
            this.txtImageLocation.Location = new System.Drawing.Point(1065, 518);
            this.txtImageLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtImageLocation.Name = "txtImageLocation";
            this.txtImageLocation.Size = new System.Drawing.Size(112, 26);
            this.txtImageLocation.TabIndex = 74;
            // 
            // txtStdID
            // 
            this.txtStdID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            this.txtStdID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStdID.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtStdID.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtStdID.Location = new System.Drawing.Point(295, 100);
            this.txtStdID.Margin = new System.Windows.Forms.Padding(2);
            this.txtStdID.Name = "txtStdID";
            this.txtStdID.ReadOnly = true;
            this.txtStdID.Size = new System.Drawing.Size(258, 37);
            this.txtStdID.TabIndex = 75;
            this.txtStdID.Text = "1233";
            this.txtStdID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(984, 443);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 29);
            this.label1.TabIndex = 76;
            this.label1.Text = "Please Select a 250 x 250 picture";
            // 
            // UserControlStudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStdID);
            this.Controls.Add(this.txtImageLocation);
            this.Controls.Add(this.btnChImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stddatetimepickerDOB);
            this.Controls.Add(this.lblstdDOB);
            this.Controls.Add(this.rbtnstdFemale);
            this.Controls.Add(this.rbtnstdMale);
            this.Controls.Add(this.lblstdGender);
            this.Controls.Add(this.txtstdPhoneNo);
            this.Controls.Add(this.lblstdaddress);
            this.Controls.Add(this.txtstdAddress);
            this.Controls.Add(this.lblstdPhoneNumber);
            this.Controls.Add(this.txtstdLastName);
            this.Controls.Add(this.lblstdLastName);
            this.Controls.Add(this.txtstdFirstName);
            this.Controls.Add(this.lblstdFirstName);
            this.Controls.Add(this.lblstdID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlStudentRegistration";
            this.Size = new System.Drawing.Size(1394, 955);
            this.Load += new System.EventHandler(this.UserControlStudentRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker stddatetimepickerDOB;
        private System.Windows.Forms.Label lblstdDOB;
        private System.Windows.Forms.RadioButton rbtnstdFemale;
        private System.Windows.Forms.RadioButton rbtnstdMale;
        private System.Windows.Forms.Label lblstdGender;
        private System.Windows.Forms.TextBox txtstdPhoneNo;
        private System.Windows.Forms.Label lblstdaddress;
        private System.Windows.Forms.TextBox txtstdAddress;
        private System.Windows.Forms.Label lblstdPhoneNumber;
        private System.Windows.Forms.TextBox txtstdLastName;
        private System.Windows.Forms.Label lblstdLastName;
        private System.Windows.Forms.TextBox txtstdFirstName;
        private System.Windows.Forms.Label lblstdFirstName;
        private System.Windows.Forms.Label lblstdID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChImage;
        private System.Windows.Forms.TextBox txtImageLocation;
        private System.Windows.Forms.TextBox txtStdID;
        private System.Windows.Forms.Label label1;
    }
}
