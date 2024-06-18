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
using Class_Pilot.Classes;

namespace Class_Pilot
{
    public partial class UserControlClassEdit : UserControl
    {
        
        public UserControlClassEdit()
        {
            InitializeComponent();

        }
        readonly string[] tuNameArry = new string[75];

        private void UserControlClassEdit_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string constring = ConnectionString.constring;
            using (SqlConnection conn = new SqlConnection(constring))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT class_table.*, teacher.firstName, teacher.lastName FROM class_table " +
                    $"INNER JOIN teacher ON class_table.tutorID = teacher.tutorID " +
                    $"WHERE class_table.classID = {textCLID.Text};";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tuNameArry[0] = reader.GetString(reader.GetOrdinal("firstName"));
                        tuNameArry[1] = reader.GetString(reader.GetOrdinal("lastName"));
                        textTRID.Text = reader.GetInt32(reader.GetOrdinal("tutorID")).ToString();
                        textTRNAME.Text = tuNameArry[0] + " " + tuNameArry[1];
                        textSUB.Text = reader.GetString(reader.GetOrdinal("subject"));
                        txtGD.Text = reader.GetString(reader.GetOrdinal("grade"));
                        string medium = reader.GetString(reader.GetOrdinal("medium"));
                        textCLFEE.Text = reader.GetSqlValue(reader.GetOrdinal("classFee")).ToString();
                        if (medium == "Sinhala")
                        {
                            radioButton1.Checked = true;
                            radioButton2.Checked = false;
                        }
                        else
                        {
                            radioButton2.Checked = true;
                            radioButton1.Checked = false;
                        }
                    
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { conn.Close(); }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = ConnectionString.constring;
            string classID = textCLID.Text;
            using (SqlConnection con = new SqlConnection(constring))
            {
                string updateQuery = $"UPDATE class_table SET subject='{textSUB.Text}' , grade='{txtGD.Text}' , classFee='{textCLFEE.Text}' WHERE classID = {classID}";
                SqlCommand command = new SqlCommand(updateQuery, con);
                try
                {
                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No rows updated.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }
    }
}
