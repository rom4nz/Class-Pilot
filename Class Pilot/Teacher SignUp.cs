using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Class_Pilot.Classes;

namespace Class_Pilot
{
    public partial class Teacher_SignUp : Form
    {
        public Teacher_SignUp()
        {
            InitializeComponent();
        }

        string Gender;
        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Teacher_SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            string firstName = textBox2.Text;
            string lastName = textBox3.Text;
            string username = txtUsername.Text;
            string password = textBox5.Text;
            string repassword = textBox6.Text;
            string phoneNo = textBox7.Text;
            string address = textBox8.Text;
            string qualifications = textBox9.Text;

            //Check if any field is empty
            if (firstName == "" || lastName == "" || username == "" || password == "" || repassword == "" || phoneNo == "" || address == "" || qualifications == "")
            {
                MessageBox.Show("Please fill all the fields.","Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                return;
            }

            //Check if password and re-entered password match
            if (password != repassword)
            {
                MessageBox.Show("Passwords do not match. Please re-enter the passwords.", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                textBox5.Text = "";
                textBox6.Text = "";
                return;
            }
            string constring = ConnectionString.constring;
            using (SqlConnection con = new SqlConnection(constring))
            {
                try
                {
                    con.Open();
                    // Check if username already exists
                    string checkQuery = $"SELECT COUNT(*) FROM teacher WHERE username = '{username}';";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    int userExists = (int)checkCmd.ExecuteScalar();

                    if (userExists > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.","Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                        txtUsername.Text = "";
                        return;
                    }

                    string query = $"Insert into teacher(firstName, lastName, username, password, phoneNo, address, gender, qualification) VALUES ('{firstName}','{lastName}','{username}','{password}','{phoneNo}','{address}',@Gender,'{qualifications}');";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registered Successfully!");

                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }
    }
}
