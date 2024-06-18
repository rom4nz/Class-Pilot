using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using Class_Pilot.Classes;

namespace Class_Pilot
{
    public partial class Delete_TuteExamPaper : Form
    {
        public Delete_TuteExamPaper()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string connection = ConnectionString.constring;
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string selectQuery = $"SELECT tuteName FROM tute_exam WHERE tuteID='{textBox1.Text}'";
            SqlCommand command = new SqlCommand(selectQuery, con);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                textBox3.Text = reader.GetString(0).ToString();

            }
            else
            {
                MessageBox.Show("Data not found!");
            }
            Tute_ExamePaperSubmission tute_ExamePaperSubmission = new Tute_ExamePaperSubmission();
            tute_ExamePaperSubmission.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = ConnectionString.constring; // Replace with your details
            try
            { 
                using (SqlConnection con = new SqlConnection(connectionString)) // Open and close connection automatically
                {
                    con.Open();
                    string tuteID = textBox1.Text.Trim();
                    string query = $"DELETE FROM tute_exam WHERE tuteID = @tuteID";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@tuteID", textBox1.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Paper deleted Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No records were deleted. Check if the tuteID exists.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting data: {ex.Message}");
                // Optionally, log the error for further analysis

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tute_ExamePaperSubmission tute_ExamePaperSubmission = new Tute_ExamePaperSubmission();
            tute_ExamePaperSubmission.Show();
        }
    }
}
