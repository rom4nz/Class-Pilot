using System;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Class_Pilot.Classes;
using System.IO;


namespace Class_Pilot
{
    public partial class Attendance : System.Windows.Forms.UserControl
    {
        string[] nameArry = new string[75];

        public Attendance()
        {
            InitializeComponent();
        }

        public void ClearData()
        {
            txtClassID.Text = string.Empty;
            txtClassName.Text = string.Empty;
            txtStudentID.Text = string.Empty;
            txtStuName.Text = string.Empty;
            txtPaymentStatus.Text = string.Empty;
            lblBirthDate.Text = string.Empty;
            lblClassName.Text = string.Empty;
            lblGrade.Text = string.Empty;
            lblMedium.Text = string.Empty;
            lblStuAddress.Text = string.Empty;
            lblStuName.Text = string.Empty;
            lblStuPhoneNo.Text = string.Empty;
            lblSubject.Text = string.Empty;
            lblTeacherName.Text = string.Empty;
            pictureBox1.Image = null;
        }

        public void PaymentStatus(int studentID, int classID)
        {
            string connectionString = ConnectionString.constring;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = string.Empty;
                    if (!string.IsNullOrEmpty(txtClassID.Text) && !string.IsNullOrEmpty(txtStudentID.Text))
                    {
                        query = $"SELECT date FROM payments WHERE classID = {classID} AND studentID = {studentID};";
                    }

                    if (!string.IsNullOrEmpty(query))
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int dateColumnOrdinal = reader.GetOrdinal("date");
                                DateTime date = reader.GetDateTime(dateColumnOrdinal);
                                if ((DateTime.Now - date).TotalDays > 30 || DateTime.Now.Day == 2)
                                {
                                    txtPaymentStatus.Text = "Not Paid";
                                    txtPaymentStatus.ForeColor = Color.Red;
                                }
                                else
                                {
                                    txtPaymentStatus.Text = "Paid";
                                    txtPaymentStatus.ForeColor = Color.Green;
                                }
                            }
                        }
                        else
                        {
                            txtPaymentStatus.Text = "Not Paid";
                            txtPaymentStatus.ForeColor = Color.Red;
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
        private void Attendance_Load(object sender, EventArgs e)
        {
            Refresh();
            ClearData();
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
                    txtClassName.AutoCompleteCustomSource = myCollection;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { conn.Close(); }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            string stuID = txtStudentID.Text;

            string connectionString = ConnectionString.constring;
            using (SqlConnection conn = new SqlConnection(connectionString))
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
                        nameArry[0] = reader.GetString(reader.GetOrdinal("firstName"));
                        nameArry[1] = reader.GetString(reader.GetOrdinal("lastName"));

                        txtStuName.Text = nameArry[0] + " " + nameArry[1];
                        lblStuName.Text = nameArry[0] + " " + nameArry[1];
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
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally 
                { 
                    conn.Close();
                    PaymentStatus(int.Parse(stuID), int.Parse(txtClassID.Text));
                }
            }
            
        }

        private void lblStuPhoneNo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
                    string query = $"SELECT studentID, firstName, lastName, phoneNo, address, DOB, photo_upload  FROM student WHERE CONCAT(firstName, ' ', lastName) LIKE '%{stuName}%';";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        nameArry[0] = reader.GetString(reader.GetOrdinal("firstName"));
                        nameArry[1] = reader.GetString(reader.GetOrdinal("lastName"));
                        txtStudentID.Text = reader.GetInt32(reader.GetOrdinal("studentID")).ToString();
                        txtStuName.Text = nameArry[0] + " " + nameArry[1];
                        lblStuName.Text = nameArry[0] + " " + nameArry[1];
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
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally 
                { 
                    conn.Close();
                    PaymentStatus(int.Parse(txtStudentID.Text), int.Parse(txtClassID.Text));
                }
            }

            
        }

        private void btnClassID_Click(object sender, EventArgs e)
        {
            string classID = txtClassID.Text;
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
                        nameArry[0] = reader.GetString(reader.GetOrdinal("firstName"));
                        nameArry[1] = reader.GetString(reader.GetOrdinal("lastName"));
                        txtClassName.Text = reader.GetString(reader.GetOrdinal("className"));
                        lblClassName.Text = reader.GetString(reader.GetOrdinal("className"));
                        lblTeacherName.Text = nameArry[0] + " " + nameArry[1];
                        lblSubject.Text = reader.GetString(reader.GetOrdinal("subject"));
                        lblGrade.Text = reader.GetString(reader.GetOrdinal("grade"));
                        lblMedium.Text = reader.GetString(reader.GetOrdinal("medium"));
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
                finally 
                { 
                    conn.Close(); 
                    
                }
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnClassName_Click(object sender, EventArgs e)
        {
            string className = txtClassName.Text;
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
                        nameArry[0] = reader.GetString(reader.GetOrdinal("firstName"));
                        nameArry[1] = reader.GetString(reader.GetOrdinal("lastName"));

                        txtClassID.Text = reader.GetInt32(reader.GetOrdinal("classID")).ToString();
                        lblClassName.Text = reader.GetString(reader.GetOrdinal("className"));
                        lblTeacherName.Text = nameArry[0] + " " + nameArry[1];
                        lblSubject.Text = reader.GetString(reader.GetOrdinal("subject"));
                        lblGrade.Text = reader.GetString(reader.GetOrdinal("grade"));
                        lblMedium.Text = reader.GetString(reader.GetOrdinal("medium"));
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

        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            string stuID = txtStudentID.Text;
            string classID = txtClassID.Text;
            DateTime attendDate = dateTimePicker1.Value;
            string connectionString = ConnectionString.constring;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"INSERT INTO student_attendence (studentID, classID, date) VALUES ({stuID}, {classID}, @attendDate);";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@attendDate", attendDate);
                    int i = cmd.ExecuteNonQuery();
                    if (i > -1)
                    {
                        txtAttendanceStatus.Text = "Attendance Marked";
                        txtAttendanceStatus.ForeColor = Color.Green;
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
            ClearData();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Student_TuteSubmission form = new Student_TuteSubmission();
            form.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
    }
}
