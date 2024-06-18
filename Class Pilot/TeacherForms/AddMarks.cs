using Class_Pilot.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Teacher_Admin_Panel___Side_menu
{
    public partial class AddMarks : Form
    {
        public AddMarks()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtstID.Text) || string.IsNullOrEmpty(txtEx.Text) || string.IsNullOrEmpty(txtmarks.Text))
            {
                MessageBox.Show("Please enter data in all fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string ClassID = Global.classID;
                string constring = ConnectionString.constring;


                SqlConnection con = new SqlConnection(constring);
                con.Open();
                string selectQuery = "INSERT INTO student_marks(studentID, grade, classID, examType, marks) VALUES (@studentID,@grade, @classID, @examtype,@marks) ";
                SqlCommand command = new SqlCommand(selectQuery, con);
                command.Parameters.AddWithValue("@studentID", txtstID.Text);
                command.Parameters.AddWithValue("@examtype", txtEx.Text);
                command.Parameters.AddWithValue("@marks", txtmarks.Text);
                command.Parameters.AddWithValue("@grade", txtgrade.Text);
                command.Parameters.AddWithValue("@classID",ClassID);
                // Add more parameter assignments for additional data

                command.ExecuteNonQuery();
                con.Close();

            }
            txtstID.Text = "";
            txtEx.Text = "";
            txtmarks.Text = "";

            MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
