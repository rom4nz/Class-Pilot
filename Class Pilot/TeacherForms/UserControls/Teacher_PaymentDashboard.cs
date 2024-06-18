using Microsoft.Data.SqlClient;
using Classpilot___PaymentReport02;
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
using Class_Pilot.Classes;

namespace Class_Pilot
{
    public partial class Teacher_PaymentDashboard : UserControl
    {
        public Teacher_PaymentDashboard()
        {
            InitializeComponent();
        }

        private void Teacher_PaymentDashboard_Load(object sender, EventArgs e)
        {
            this.Hide();

            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
            btn4.Visible = false;
            btn5.Visible = false;
            btn6.Visible = false;
            btn7.Visible = false;
            btn8.Visible = false;
            btn9.Visible = false;
            btn10.Visible = false;
            btn11.Visible = false;
            btn12.Visible = false;


            string constring = ConnectionString.constring;
            SqlConnection con = new SqlConnection(constring);
            if (int.TryParse(Global.userID, out int userID))
            {
                Console.WriteLine($"Logged in UserID: {userID}");
                try
                {
                    con.Open();

                    string query = $"SELECT classID, className FROM class_table WHERE tutorID = @userID;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@userID", userID);
                    SqlDataReader dr = cmd.ExecuteReader();

                    List<int> classIDs = new List<int>();
                    List<string> classNames = new List<string>();

                    while (dr.Read())
                    {
                        int classID = dr.GetInt32(0);
                        classIDs.Add(classID);
                        string className = dr.GetString(1);
                        classNames.Add(className);
                    }

                    int classCount = classIDs.Count;
                    Console.WriteLine($"Counted classes: {classCount}");


                    for (int i = 0; i < classCount; i++)
                    {
                        string btnName = "btn" + (i + 1);
                        if (Controls.ContainsKey(btnName))
                        {
                            Button btn = (Button)Controls[btnName];
                            Console.WriteLine($"Setting {btnName} visibility to true");
                            btn.Visible = true;
                            int classID = classIDs[i];
                            string className = classNames[i];
                            btn.Text = $"ID: {classID}\n\nName: {className}";
                            btn.Tag = classIDs[i].ToString(); // Set the Tag property to store classID
                            btn.Click += Btn_Click; // Assign a click event handler
                            Console.WriteLine($"{btnName} visibility is now {btn.Visible}");
                            this.Refresh();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Sql error: {ex.Message}");
                }
                finally
                {
                    con.Close();
                }

            }

            else
            {
                userID = 0;
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button clickedBtn = sender as Button;
            if (clickedBtn != null)
            {
                int classID = int.Parse(clickedBtn.Tag.ToString());
                Global.classID = classID.ToString();
                userControlPaymentReport021.Show();

            }
        }
    }

   


    
}
