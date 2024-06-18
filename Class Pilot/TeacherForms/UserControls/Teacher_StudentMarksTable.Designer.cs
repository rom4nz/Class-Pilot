namespace Teacher_Admin_Panel___Side_menu
{
    partial class Teacher_StudentMarksTable
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dataGridViewStdMarks = new System.Windows.Forms.DataGridView();
            this.btnAddMarks = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStdMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLoad);
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.btnsearch);
            this.panel3.Controls.Add(this.dataGridViewStdMarks);
            this.panel3.Controls.Add(this.btnAddMarks);
            this.panel3.Controls.Add(this.txtsearch);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(13, 21);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1147, 696);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.btnBack.Image = global::Class_Pilot.Properties.Resources.arrow;
            this.btnBack.Location = new System.Drawing.Point(52, 17);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 52);
            this.btnBack.TabIndex = 73;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Image = global::Class_Pilot.Properties.Resources.search_interface_symbol;
            this.btnsearch.Location = new System.Drawing.Point(951, 110);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnsearch.Size = new System.Drawing.Size(132, 34);
            this.btnsearch.TabIndex = 68;
            this.btnsearch.Text = "Search";
            this.btnsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dataGridViewStdMarks
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStdMarks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStdMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStdMarks.Location = new System.Drawing.Point(52, 163);
            this.dataGridViewStdMarks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewStdMarks.Name = "dataGridViewStdMarks";
            this.dataGridViewStdMarks.RowHeadersWidth = 51;
            this.dataGridViewStdMarks.RowTemplate.Height = 24;
            this.dataGridViewStdMarks.Size = new System.Drawing.Size(683, 365);
            this.dataGridViewStdMarks.TabIndex = 25;
            // 
            // btnAddMarks
            // 
            this.btnAddMarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.btnAddMarks.FlatAppearance.BorderSize = 0;
            this.btnAddMarks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(122)))));
            this.btnAddMarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMarks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMarks.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddMarks.Location = new System.Drawing.Point(52, 110);
            this.btnAddMarks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddMarks.Name = "btnAddMarks";
            this.btnAddMarks.Size = new System.Drawing.Size(151, 34);
            this.btnAddMarks.TabIndex = 24;
            this.btnAddMarks.Text = "Add Marks";
            this.btnAddMarks.UseVisualStyleBackColor = false;
            this.btnAddMarks.Click += new System.EventHandler(this.btnAddMarks_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(701, 113);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(244, 30);
            this.txtsearch.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(588, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Student ID";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(126)))), ((int)(((byte)(243)))));
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(122)))));
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLoad.Location = new System.Drawing.Point(224, 99);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(151, 45);
            this.btnLoad.TabIndex = 74;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Teacher_StudentMarksTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Teacher_StudentMarksTable";
            this.Size = new System.Drawing.Size(1184, 708);
            this.Load += new System.EventHandler(this.Teacher_StudentMarksTable_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStdMarks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewStdMarks;
        private System.Windows.Forms.Button btnAddMarks;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLoad;
    }
}
