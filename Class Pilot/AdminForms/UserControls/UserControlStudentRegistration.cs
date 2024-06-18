using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_Pilot.Classes;
using Microsoft.Data.SqlClient;

namespace Class_Pilot
{
    public partial class UserControlStudentRegistration : UserControl
    {
        public UserControlStudentRegistration()
        {
            InitializeComponent();

        }
        string Gender;

        private void UserControlStudentRegistration_Load(object sender, EventArgs e)
        {
            this.Hide();
            GetStudentID();
            txtImageLocation.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtstdFirstName.Text) || string.IsNullOrEmpty(txtstdLastName.Text) ||
                string.IsNullOrEmpty(txtstdPhoneNo.Text) || string.IsNullOrEmpty(txtstdAddress.Text) ||
                string.IsNullOrEmpty(stddatetimepickerDOB.Text) || string.IsNullOrEmpty(txtImageLocation.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string constring = ConnectionString.constring;
                SqlConnection con = new SqlConnection(constring);

                try
                {
                    con.Open();

                    string firstName = txtstdFirstName.Text;
                    string lastName = txtstdLastName.Text;
                    string phoneNo = txtstdPhoneNo.Text;
                    string address = txtstdAddress.Text;
                    string DOB = stddatetimepickerDOB.Value.ToString("yyyy-MM-dd");
                    string PicLocation = txtImageLocation.Text;

                    // Convert image to byte array
                    byte[] imageData = File.ReadAllBytes(PicLocation);

                    string query = $"INSERT INTO student (firstName, lastName, phoneNo, address,gender, DOB,photo_upload) VALUES (@FirstName, @LastName, @PhoneNo, @Address, @Gender, @DOB, @Image)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@PhoneNo", phoneNo);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@DOB", DOB);
                    cmd.Parameters.AddWithValue("@Image", imageData);

                    int i = cmd.ExecuteNonQuery();
                    if (i > -1)
                    {
                        MessageBox.Show("Student Registration Successful!", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ClearField();
                    GetStudentID();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL Error : {ex.Message}");
                }
                finally
                {
                    con.Close();
                }

            }
        }

        private void ClearField()
        {
            txtstdFirstName.Text = "";
            txtstdLastName.Text = "";
            txtstdPhoneNo.Text = "";
            txtstdAddress.Text = "";
            rbtnstdMale.Checked = false;
            rbtnstdFemale.Checked = false;
            pictureBox1.Image = null;
            txtImageLocation.Text = "";

        }

        private void GetStudentID()
        {
            string stdID;
            string constring = "Server=tcp:class-pilot.database.windows.net,1433;Initial Catalog=class_pilotDB;Persist Security Info=False;User ID=gavin@class-pilot;Password=G@vin#2oo3;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection con = new SqlConnection(constring);

            con.Open();

            string query = "SELECT studentID FROM student ORDER BY studentID Desc";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int id = int.Parse(reader[0].ToString()) + 1;
                stdID = id.ToString("00000");
            }
            else if(Convert.IsDBNull(reader)) 
            {
                stdID = ("00001");
            }
            else
            {
                stdID = ("00001");
            }
            con.Close();
            txtStdID.Text = stdID.ToString();

        }

        private void rbtnstdMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void rbtnstdFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void btnChImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog imgDialog = new OpenFileDialog();
            imgDialog.Filter = "Image Files (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp|All Files (*.*)|*.*";

            if (imgDialog.ShowDialog() == DialogResult.OK)
            {
                string picLoc = imgDialog.FileName.ToString();
                pictureBox1.ImageLocation = picLoc;
                txtImageLocation.Text = picLoc;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtstdFirstName.Text = "";
            txtstdLastName.Text = "";
            txtstdPhoneNo.Text = "";
            txtstdAddress.Text = "";
            rbtnstdMale.Checked = false;
            rbtnstdFemale.Checked = false;
            pictureBox1.Image = null;
            txtImageLocation.Text = "";

        }
    }
}
