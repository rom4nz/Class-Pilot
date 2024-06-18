using Class_Pilot.Classes;
using Org.BouncyCastle.Bcpg;
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

namespace Class_Pilot
{

    public partial class Student_TuteSubmission : Form
    {

        string[] nameArry = new string[75];
        public Student_TuteSubmission()
        {
            InitializeComponent();
            
        }


        private void btnStuID_Click(object sender, EventArgs e)
        {
            string stuID = txtStudentID.Text;
            string connectionString = ConnectionString.constring;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT firstName, lastName FROM student WHERE studentID = '{stuID}';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        nameArry[0] = reader.GetString(reader.GetOrdinal("firstName"));
                        nameArry[1] = reader.GetString(reader.GetOrdinal("lastName"));
                    }

                    txtStuName.Text = nameArry[0] + " " + nameArry[1];
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { conn.Close(); }
            }
        }

        private void btnStuName_Click(object sender, EventArgs e)
        {
            string stuName = txtStuName.Text;
            string connectionString = ConnectionString.constring;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT studentID, firstName FROM student WHERE CONCAT(firstName, ' ', lastName) LIKE '%{stuName}%';";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        nameArry[0] = reader.GetString(reader.GetOrdinal("firstName"));
                        nameArry[1] = reader.GetString(reader.GetOrdinal("lastName"));
                    }
                    txtStudentID.Text = reader.GetInt32(reader.GetOrdinal("studentID")).ToString();
                    txtStuName.Text = nameArry[0] + " " + nameArry[1];
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { conn.Close(); }
            }
        }

        private void Student_TuteSubmission_Load(object sender, EventArgs e)
        {
            txtTuteID.Hide();
            string connectionString = ConnectionString.constring;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT firstName, lastName FROM student;";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();
                    while (reader.Read())
                    {
                        myCollection.Add(reader.GetString(0) + " " + reader.GetString(1));
                    }
                    txtStuName.AutoCompleteCustomSource = myCollection;
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    conn.Open();
                    string query = $"SELECT tuteName FROM tute_exam;";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader.GetString(0));  
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { conn.Close(); }
            }
        }

        private void btnSubmitTute_Click(object sender, EventArgs e)
        {
            string stuID = txtStudentID.Text;
            string tuteID = txtTuteID.Text;
            string connectionString = ConnectionString.constring;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"INSERT INTO student_tutes (studentID, tuteID, tuteGiven) VALUES ({stuID}, {tuteID}, 1);";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    int i = cmd.ExecuteNonQuery();
                    if (i > -1)
                    {
                        MessageBox.Show("Tute Submitted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string tuteName = comboBox1.Text;
            string connectionString = ConnectionString.constring;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT tuteID FROM tute_exam WHERE tuteName = '{tuteName}';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        txtTuteID.Text = reader.GetInt32(0).ToString();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { conn.Close(); }
            }
        }
    }
}
