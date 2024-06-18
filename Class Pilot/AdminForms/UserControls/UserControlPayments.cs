using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_Pilot.Classes;
using System.IO;

namespace Class_Pilot
{
    public partial class UserControlPayments : UserControl
    {
        public UserControlPayments()
        {
            InitializeComponent();
            ClearData();
        }
        readonly string[] tuNameArry = new string[75];

        public void ClearData()
        {
            txtClassID.Text = string.Empty;
            txtClName.Text = string.Empty;
            txtStudentID.Text = string.Empty;
            txtStuName.Text = string.Empty;
            txtPaymentStatus.Text = string.Empty;
            lblBirthDate.Text = string.Empty;
            lblClName.Text = string.Empty;
            lblGd.Text = string.Empty;
            lblClFee.Text = string.Empty;
            lblStuAddress.Text = string.Empty;
            lblStuName.Text = string.Empty;
            lblStuPhoneNo.Text = string.Empty;
            pictureBox1.Image = null;
            lblTuName.Text = string.Empty;
            lblSub.Text = string.Empty;
        }

        private void UserControlPayments_Load(object sender, EventArgs e)
        {
            this.Hide();
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
                    MessageBox.Show($"SQL Error {ex.Message}");
                }

                try
                {
                    conn.Open();
                    string query = $"SELECT className FROM class_table;";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();
                    while (reader.Read())
                    {
                        myCollection.Add(reader.GetString(0));
                    }
                    txtClName.AutoCompleteCustomSource = myCollection;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { conn.Close(); }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string classID = txtClassID.Text;
            if(string.IsNullOrEmpty(classID) || string.IsNullOrEmpty(txtStudentID.Text))
            {
                MessageBox.Show("Please enter relevant fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string connectionString = ConnectionString.constring;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT class_table.*, teacher.firstName, teacher.lastName FROM class_table " +
                    $"INNER JOIN teacher ON class_table.tutorID = teacher.tutorID " +
                    $"WHERE class_table.classID = {classID};";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    bool hasData = false;
                    while (reader.Read())
                    {
                        hasData = true;
                        tuNameArry[0] = reader.GetString(reader.GetOrdinal("firstName"));
                        tuNameArry[1] = reader.GetString(reader.GetOrdinal("lastName"));
                        txtClName.Text = reader.GetString(reader.GetOrdinal("className"));
                        lblClName.Text = reader.GetString(reader.GetOrdinal("className"));
                        lblTuName.Text = tuNameArry[0] + " " + tuNameArry[1];
                        lblSub.Text = reader.GetString(reader.GetOrdinal("subject"));
                        lblGd.Text = reader.GetString(reader.GetOrdinal("grade"));
                        lblClFee.Text = reader.GetSqlValue(reader.GetOrdinal("classFee")).ToString();
                    }

                    if (!hasData)
                    {
                        MessageBox.Show("No class found with the provided class ID.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { conn.Close(); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string className = txtClName.Text;
            string connectionString = ConnectionString.constring;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT class_table.*, teacher.firstName, teacher.lastName FROM class_table " +
                    $"INNER JOIN teacher ON class_table.tutorID = teacher.tutorID " +
                    $"WHERE class_table.className = '{className}';";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tuNameArry[0] = reader.GetString(reader.GetOrdinal("firstName"));
                        tuNameArry[1] = reader.GetString(reader.GetOrdinal("lastName"));

                        txtClassID.Text = reader.GetInt32(reader.GetOrdinal("classID")).ToString();
                        txtClName.Text = reader.GetString(reader.GetOrdinal("className"));
                        lblClName.Text = reader.GetString(reader.GetOrdinal("className"));
                        lblTuName.Text = tuNameArry[0] + " " + tuNameArry[1];
                        lblSub.Text = reader.GetString(reader.GetOrdinal("subject"));
                        lblGd.Text = reader.GetString(reader.GetOrdinal("grade"));
                        lblClFee.Text = reader.GetSqlValue(reader.GetOrdinal("classFee")).ToString();
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

        public void PaymentStatus()
        {
            string constring = ConnectionString.constring;
            using (SqlConnection conn = new SqlConnection(constring))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT * FROM payments;";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                    }
                    int day = 2;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { conn.Close(); }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string stuID = txtStudentID.Text;
            string constring = ConnectionString.constring;
            using (SqlConnection conn = new SqlConnection(constring))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT firstName, lastName, phoneNo, address, DOB, photo_upload  FROM student WHERE studentID = '{stuID}';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    bool hasData = false;
                    while (reader.Read())
                    {
                        hasData = true;
                        tuNameArry[0] = reader.GetString(reader.GetOrdinal("firstName"));
                        tuNameArry[1] = reader.GetString(reader.GetOrdinal("lastName"));

                        txtStuName.Text = tuNameArry[0] + " " + tuNameArry[1];
                        lblStuName.Text = tuNameArry[0] + " " + tuNameArry[1];
                        lblStuPhoneNo.Text = reader.GetInt32(reader.GetOrdinal("phoneNo")).ToString();
                        lblStuAddress.Text = reader.GetString(reader.GetOrdinal("address"));
                        lblBirthDate.Text = reader.GetDateTime(reader.GetOrdinal("DOB")).ToString("dd/MM/yyyy");

                        // Read image data from database
                        byte[] imageData = (byte[])reader["photo_upload"];
                        // Convert byte array to Image
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    if (!hasData)
                    {
                        MessageBox.Show("No Student found with the provided Student ID.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL Error {ex.Message}");
                }
                finally { conn.Close(); }

            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            string stuName = txtStuName.Text;
            string constring = ConnectionString.constring;
            using (SqlConnection conn = new SqlConnection(constring))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT studentID, firstName, lastName, phoneNo, address, DOB, photo_upload  FROM student WHERE CONCAT(firstName, ' ', lastName) LIKE '%{stuName}%';";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tuNameArry[0] = reader.GetString(reader.GetOrdinal("firstName"));
                        tuNameArry[1] = reader.GetString(reader.GetOrdinal("lastName"));

                        txtStudentID.Text = reader.GetInt32(reader.GetOrdinal("studentID")).ToString();
                        txtStuName.Text = tuNameArry[0] + " " + tuNameArry[1];
                        lblStuName.Text = tuNameArry[0] + " " + tuNameArry[1];
                        lblStuPhoneNo.Text = reader.GetInt32(reader.GetOrdinal("phoneNo")).ToString();
                        lblStuAddress.Text = reader.GetString(reader.GetOrdinal("address"));
                        lblBirthDate.Text = reader.GetDateTime(reader.GetOrdinal("DOB")).ToString("dd/MM/yyyy");

                        // Read image data from database
                        byte[] imageData = (byte[])reader["photo_upload"];
                        // Convert byte array to Image
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error");
                }
                finally { conn.Close(); }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string stuID = txtStudentID.Text;
            string classID = txtClassID.Text;
            DateTime paymentDate = dateTimePicker1.Value;
            string constring = ConnectionString.constring;
            using (SqlConnection conn = new SqlConnection(constring))
            {
                try
                {
                    conn.Open();
                    string query = $"INSERT INTO payments (studentID, classID, date) VALUES ({stuID}, {classID}, @paymentDate);";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@paymentDate", paymentDate);

                    int i = cmd.ExecuteNonQuery();
                    if (i > -1)
                    {
                        txtPaymentStatus.Text = "Paid";
                        txtPaymentStatus.ForeColor = Color.Green;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
