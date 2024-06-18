using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Data.SqlClient;
using Class_Pilot.Classes;


namespace Class_Pilot
{
    public partial class UserControlStdEdit_StudentDetailsEdit : UserControl
    {
        public UserControlStdEdit_StudentDetailsEdit()
        {
            InitializeComponent();
        }
        string Language;

        private void UserControlStdEdit_StudentDetailsEdit_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtStdID.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtPhNum.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Connection String (from ConnectionString.cs)
                string constring = ConnectionString.constring;
                SqlConnection con = new SqlConnection(constring);

                string selectQuery = $"SELECT studentID FROM student WHERE studentID = '{txtStdID.Text}'";
                SqlCommand selectCommand = new SqlCommand(selectQuery, con);

                try
                {
                    con.Open();
                    object result = selectCommand.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("The student ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string insertQuery = $"INSERT INTO student (studentID,firstName,lastName,phoneNo,address) VALUES ('{txtStdID.Text}','{txtFirstName.Text}','{txtLastName.Text}','{txtPhNum.Text}','{txtAddress.Text}')";
                        SqlCommand insertCommand = new SqlCommand(insertQuery, con);
                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No rows inserted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { con.Close(); }
            }
           
        }

        
        private void txtStdID_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtStdID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhNum.Clear();
            txtAddress.Clear();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            string constring = ConnectionString.constring;
            using (SqlConnection con = new SqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string selectQuery = $"SELECT firstName,lastName,phoneNo,address FROM student WHERE studentID= '{txtStdID.Text}'";
                    SqlCommand command = new SqlCommand(selectQuery, con);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txtFirstName.Text = reader.GetValue(0).ToString();
                        txtLastName.Text = reader.GetValue(1).ToString();
                        txtPhNum.Text = reader.GetValue(2).ToString();
                        txtAddress.Text = reader.GetValue(3).ToString();
                    }
                    else
                    {
                        MessageBox.Show("No Data For This ID");
                    }
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
