using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Class_Pilot.Classes;

namespace Class_Pilot
{
    public partial class UserControlStdEdit_AssignToClass : UserControl
    {
        public UserControlStdEdit_AssignToClass()
        {
            InitializeComponent();
        }
        string[] tuNameArry = new string[75];
        string Language;

        private void UserControlStdEdit_AssignToClass_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtClEdit.Text == "" || txtStdID.Text == "")
            {
                MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Connection String (from ConnectionString.cs)
                string constring = ConnectionString.constring;
                SqlConnection con = new SqlConnection(constring);

                string selectQuery = $"SELECT classID FROM student WHERE studentID = '{txtStdID.Text}'";
                SqlCommand selectCommand = new SqlCommand(selectQuery, con);

                try
                {
                    con.Open();
                    object result = selectCommand.ExecuteScalar();
                    if (result != null && result.ToString() == txtClEdit.Text)
                    {
                        MessageBox.Show("The student is already assigned to this class.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        string updateQuery = $"UPDATE student SET classID='{txtClEdit.Text}' WHERE studentID = '{txtStdID.Text}'";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, con);
                        int rowsAffected = updateCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No rows updated.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }

        }

        private void txtClEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            string connectionString = ConnectionString.constring;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT class_table.*, teacher.firstName, teacher.lastName FROM class_table " +
                    $"INNER JOIN teacher ON class_table.tutorID = teacher.tutorID " +
                    $"WHERE class_table.classID = {txtClEdit.Text};";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    bool hasData = false; //Check if there is data to ID number
                    while (reader.Read())
                    {
                        hasData = true;
                        tuNameArry[0] = reader.GetString(reader.GetOrdinal("firstName"));
                        tuNameArry[1] = reader.GetString(reader.GetOrdinal("lastName"));
                        txtTutorID.Text = reader.GetInt32(reader.GetOrdinal("tutorID")).ToString();
                        txtTutorName.Text = tuNameArry[0] + " " + tuNameArry[1];
                        txtSub.Text = reader.GetString(reader.GetOrdinal("subject"));
                        comboBoxGrade.Text = reader.GetString(reader.GetOrdinal("grade"));
                    }

                    if (!hasData)
                    {
                        MessageBox.Show("No data found for this class ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { conn.Close(); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = ConnectionString.constring;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string selectQuery = $"SELECT firstName,lastName,phoneNo FROM student WHERE studentID= '{txtStdID.Text}'";
            SqlCommand command = new SqlCommand(selectQuery, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                txtFirstName.Text = reader.GetValue(0).ToString();
                txtLastName.Text = reader.GetValue(1).ToString();
                txtPhNum.Text = reader.GetValue(2).ToString();
            }
            else
            {
                MessageBox.Show("No Data For This Id");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtClEdit.Clear();
            txtTutorID.Clear();
            txtTutorName.Clear();
            txtSub.Clear();
            comboBoxGrade.Text = string.Empty;
            txtStdID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhNum.Clear();
        }
    }
}
