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
using static System.Net.Mime.MediaTypeNames;
using Microsoft.Data.SqlClient;
using Class_Pilot.Classes;
using System.IO;



namespace Class_Pilot
{
    public partial class UserControlTeacherEdit : UserControl
    {
        public UserControlTeacherEdit()
        {
            InitializeComponent();
        }

        string[] nameArry = new string[75];

        public void ClearData()
        {
            txtClassID.Text = string.Empty;
            txtClassName.Text = string.Empty;
            txtTutorID.Text = string.Empty;
            txtTutorName.Text = string.Empty;
            lblClassName.Text = string.Empty;
            lblGrade.Text = string.Empty;
            lblMedium.Text = string.Empty;
            lblTutAddress.Text = string.Empty;
            lblTutName.Text = string.Empty;
            lblTutPhoneNo.Text = string.Empty;
            lblSubject.Text = string.Empty;
        }
        private void UserControlTeacherEdit_Load(object sender, EventArgs e)
        {
            ClearData();
            this.Hide();
            string connectionString = ConnectionString.constring;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT firstName, lastName FROM teacher;";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    AutoCompleteStringCollection myCollection = new AutoCompleteStringCollection();
                    while (reader.Read())
                    {
                        myCollection.Add(reader.GetString(0) + " " + reader.GetString(1));
                    }
                    txtTutorName.AutoCompleteCustomSource = myCollection;
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

        private void button2_Click(object sender, EventArgs e)
        {
           
            /*string constring = ConnectionString.constring;
            using (SqlConnection con = new SqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string selectQuery = $"SELECT classID,className FROM class_table WHERE tutorID= '{txtTuID.Text}'";
                    SqlCommand command = new SqlCommand(selectQuery, con);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        textBox2.Text = reader.GetValue(0).ToString();
                        textBox1.Text = reader.GetValue(1).ToString();


                    }
                    else
                    {
                        MessageBox.Show("No Data For This Id");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { con.Close(); }
            }*/

        }

        private void button1_Click(object sender, EventArgs e)
        {

         }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
/*            string tutorID = txtTuID.Text; 
            string classID = textBox2.Text;
            assign assignForm = new assign(tutorID, classID); 
            assignForm.Show(); */
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
                    string query = $"SELECT * FROM class_table " +
                    $"WHERE classID = {classID};";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    bool hasData = false;
                    while (reader.Read())
                    {
                        hasData = true;
                        txtClassName.Text = reader.GetString(reader.GetOrdinal("className"));
                        lblClassName.Text = reader.GetString(reader.GetOrdinal("className"));
                        lblSubject.Text = reader.GetString(reader.GetOrdinal("subject"));
                        lblGrade.Text = reader.GetString(reader.GetOrdinal("grade"));
                        lblMedium.Text = reader.GetString(reader.GetOrdinal("medium"));
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

        private void btnClassName_Click(object sender, EventArgs e)
        {
            string className = txtClassName.Text;
            string connectionString = ConnectionString.constring;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT * FROM class_table " +
                    $"WHERE className = '{className}';";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        txtClassID.Text = reader.GetInt32(reader.GetOrdinal("classID")).ToString();
                        lblClassName.Text = reader.GetString(reader.GetOrdinal("className"));
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

        private void btnStuSearch_Click(object sender, EventArgs e)
        {
            string TutID = txtTutorID.Text;
            string connectionString = ConnectionString.constring;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT firstName, lastName, phoneNo, address FROM teacher WHERE tutorID = '{TutID}';";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    bool hasData = false; 
                    while (reader.Read())
                    {
                        hasData = true;
                        nameArry[0] = reader.GetString(reader.GetOrdinal("firstName"));
                        nameArry[1] = reader.GetString(reader.GetOrdinal("lastName"));

                        txtTutorName.Text = nameArry[0] + " " + nameArry[1];
                        lblTutName.Text = nameArry[0] + " " + nameArry[1];
                        lblTutPhoneNo.Text = reader.GetString(reader.GetOrdinal("phoneNo"));
                        lblTutAddress.Text = reader.GetString(reader.GetOrdinal("address"));
                    }

                    if (!hasData)
                    {
                        MessageBox.Show("No data found for this teacher ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { conn.Close(); }
            }
        }

        private void btnTutName_Click(object sender, EventArgs e)
        {
            string tutName = txtTutorName.Text;
            string connectionString = ConnectionString.constring;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT studentID, firstName, lastName, phoneNo, address  FROM teacher WHERE CONCAT(firstName, ' ', lastName) LIKE '%{tutName}%';";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        nameArry[0] = reader.GetString(reader.GetOrdinal("firstName"));
                        nameArry[1] = reader.GetString(reader.GetOrdinal("lastName"));
                        txtTutorID.Text = reader.GetInt32(reader.GetOrdinal("studentID")).ToString();
                        txtTutorName.Text = nameArry[0] + " " + nameArry[1];
                        lblTutName.Text = nameArry[0] + " " + nameArry[1];
                        lblTutPhoneNo.Text = reader.GetInt32(reader.GetOrdinal("phoneNo")).ToString();
                        lblTutAddress.Text = reader.GetString(reader.GetOrdinal("address"));

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { conn.Close(); }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtClassID.Text == "" || txtTutorID.Text == "")
            {
                MessageBox.Show("Please enter a class ID and a teacher ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string classID = txtClassID.Text;
            string teacherID = txtTutorID.Text;
            string connectionString = ConnectionString.constring;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Check if the teacher is assigned to the class
                string checkQuery = $"SELECT COUNT(*) FROM class_table WHERE classID = '{classID}' AND tutorID = '{teacherID}';";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {
                    // The teacher is not assigned to the class
                    MessageBox.Show("The teacher is not assigned to this class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // The teacher is assigned to the class
                    string teacherName = lblTutName.Text; // Get the teacher's name
                    string className = lblClassName.Text; // Get the class's name

                    // Show a confirmation message
                    DialogResult result = MessageBox.Show($"'{teacherName}' will be removed from '{className}'. Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Remove the teacher from the class
                        string removeQuery = $"UPDATE class_table SET tutorID = NULL WHERE classID = '{classID}' AND tutorID = '{teacherID}';";
                        SqlCommand removeCmd = new SqlCommand(removeQuery, conn);
                        removeCmd.ExecuteNonQuery();

                        MessageBox.Show("The teacher has been removed from the class.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                conn.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtClassID.Text == "" || txtTutorID.Text == "")
            {
                MessageBox.Show("Please enter a class ID and a teacher ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string classID = txtClassID.Text;
            string teacherID = txtTutorID.Text;
            string connectionString = ConnectionString.constring;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // Check if the teacher is already assigned to the class
                string checkQuery = $"SELECT COUNT(*) FROM class_table WHERE classID = '{classID}' AND tutorID = '{teacherID}';";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    // The teacher is already assigned to the class
                    MessageBox.Show("The teacher is already assigned to this class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Add the teacher to the class
                    string addQuery = $"UPDATE class_table SET tutorID = '{teacherID}' WHERE classID = '{classID}';";
                    SqlCommand addCmd = new SqlCommand(addQuery, conn);
                    addCmd.ExecuteNonQuery();

                    // Get the teacher's name
                    string teacherNameQuery = $"SELECT firstName, lastName FROM teacher WHERE tutorID = '{teacherID}';";
                    SqlCommand teacherNameCmd = new SqlCommand(teacherNameQuery, conn);
                    SqlDataReader reader = teacherNameCmd.ExecuteReader();
                    reader.Read();
                    string teacherName = reader.GetString(0) + " " + reader.GetString(1);
                    reader.Close();

                    // Get the class's name
                    string classNameQuery = $"SELECT className FROM class_table WHERE classID = '{classID}';";
                    SqlCommand classNameCmd = new SqlCommand(classNameQuery, conn);
                    string className = (string)classNameCmd.ExecuteScalar();

                    MessageBox.Show($"'{teacherName}' has been added to '{className}'.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                conn.Close();
            }
        }
    }
}
    

    
