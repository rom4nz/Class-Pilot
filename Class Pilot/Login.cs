using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Class_Pilot.Classes;


namespace Class_Pilot
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUserID.Hide();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Teacher_SignUp teacher_SignUp = new Teacher_SignUp();
            teacher_SignUp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "admin@classpilot" && textBox3.Text == "adminPassword")
            {
                //Proceeds to Admin SideMenu
                AdminSideMenu sidemenu = new AdminSideMenu();
                sidemenu.Show();
                this.Hide();
            }
            else
            {
                string Username = textBox2.Text;
                string Password = textBox3.Text;
                string constring = ConnectionString.constring;
                SqlConnection con = new SqlConnection(constring);
                try
                {
                    con.Open();
                    string query = $"SELECT * FROM teacher WHERE username = '{Username}' AND password = '{Password}';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Check if there are any rows in the reader (matching username/password)
                    if (reader.HasRows)
                    {
                        reader.Read(); // Move to the first row (assuming only one match)
                        txtUserID.Text = reader.GetInt32(reader.GetOrdinal("tutorID")).ToString();
                        Global.userID = txtUserID.Text;
                        Teacher_SideMenu teacher_SideMenu = new Teacher_SideMenu();
                        teacher_SideMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password", "Warining", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Sql error: " + ex.Message); // Show specific error message
                }
                finally
                {
                    con.Close(); // Ensure connection is closed even if there's an exception
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        
    }
}
