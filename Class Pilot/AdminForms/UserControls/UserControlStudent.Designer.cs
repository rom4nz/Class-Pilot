namespace Class_Pilot.UserControls
{
    partial class UserControlStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtEndDateS = new System.Windows.Forms.DateTimePicker();
            this.dtStartDateS = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewS = new System.Windows.Forms.DataGridView();
            this.Class_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::Class_Pilot.Properties.Resources.search_interface_symbol;
            this.btnSearch.Location = new System.Drawing.Point(1070, 42);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(140, 42);
            this.btnSearch.TabIndex = 160;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(854, 42);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(208, 35);
            this.txtSearch.TabIndex = 159;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(720, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 32);
            this.label4.TabIndex = 158;
            this.label4.Text = "Student ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(340, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 32);
            this.label1.TabIndex = 156;
            this.label1.Text = "-";
            // 
            // dtEndDateS
            // 
            this.dtEndDateS.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDateS.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtEndDateS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDateS.Location = new System.Drawing.Point(486, 42);
            this.dtEndDateS.Name = "dtEndDateS";
            this.dtEndDateS.Size = new System.Drawing.Size(158, 37);
            this.dtEndDateS.TabIndex = 155;
            // 
            // dtStartDateS
            // 
            this.dtStartDateS.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDateS.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtStartDateS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDateS.Location = new System.Drawing.Point(160, 42);
            this.dtStartDateS.Name = "dtStartDateS";
            this.dtStartDateS.Size = new System.Drawing.Size(158, 37);
            this.dtStartDateS.TabIndex = 154;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(368, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 32);
            this.label2.TabIndex = 153;
            this.label2.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 32);
            this.label3.TabIndex = 152;
            this.label3.Text = "Start Date";
            // 
            // dataGridViewS
            // 
            this.dataGridViewS.AllowUserToAddRows = false;
            this.dataGridViewS.AllowUserToDeleteRows = false;
            this.dataGridViewS.AllowUserToResizeColumns = false;
            this.dataGridViewS.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Class_ID,
            this.Class_Name,
            this.Attendance,
            this.Income});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewS.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewS.EnableHeadersVisualStyles = false;
            this.dataGridViewS.Location = new System.Drawing.Point(76, 132);
            this.dataGridViewS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewS.Name = "dataGridViewS";
            this.dataGridViewS.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(151)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewS.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewS.RowHeadersVisible = false;
            this.dataGridViewS.RowHeadersWidth = 62;
            this.dataGridViewS.Size = new System.Drawing.Size(1082, 489);
            this.dataGridViewS.TabIndex = 151;
            // 
            // Class_ID
            // 
            this.Class_ID.DataPropertyName = "classID";
            this.Class_ID.HeaderText = "Class ID";
            this.Class_ID.MinimumWidth = 8;
            this.Class_ID.Name = "Class_ID";
            this.Class_ID.ReadOnly = true;
            this.Class_ID.Width = 133;
            // 
            // Class_Name
            // 
            this.Class_Name.DataPropertyName = "className";
            this.Class_Name.HeaderText = "Class Name";
            this.Class_Name.MinimumWidth = 8;
            this.Class_Name.Name = "Class_Name";
            this.Class_Name.ReadOnly = true;
            this.Class_Name.Width = 247;
            // 
            // Attendance
            // 
            this.Attendance.DataPropertyName = "totAttendance";
            this.Attendance.HeaderText = "Total Attendance";
            this.Attendance.MinimumWidth = 8;
            this.Attendance.Name = "Attendance";
            this.Attendance.ReadOnly = true;
            this.Attendance.Width = 175;
            // 
            // Income
            // 
            this.Income.DataPropertyName = "payment";
            this.Income.HeaderText = "Payment (LKR)";
            this.Income.MinimumWidth = 8;
            this.Income.Name = "Income";
            this.Income.ReadOnly = true;
            this.Income.Width = 166;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(122)))));
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(122)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(938, 662);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(220, 65);
            this.btnGenerate.TabIndex = 150;
            this.btnGenerate.Text = "Export as PDF";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Image = global::Class_Pilot.Properties.Resources.filter__1_;
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilter.Location = new System.Drawing.Point(654, 42);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnFilter.Size = new System.Drawing.Size(50, 42);
            this.btnFilter.TabIndex = 161;
            this.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // UserControlStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtEndDateS);
            this.Controls.Add(this.dtStartDateS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewS);
            this.Controls.Add(this.btnGenerate);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlStudent";
            this.Size = new System.Drawing.Size(1226, 911);
            this.Load += new System.EventHandler(this.UserControlStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtEndDateS;
        private System.Windows.Forms.DateTimePicker dtStartDateS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewS;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Income;
        private System.Windows.Forms.Button btnFilter;
    }
}
