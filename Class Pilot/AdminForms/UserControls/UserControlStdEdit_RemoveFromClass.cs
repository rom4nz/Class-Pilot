using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class UserControlStdEdit_RemoveFromClass : UserControl
    {
        public UserControlStdEdit_RemoveFromClass()
        {
            InitializeComponent();
        }

        string[] stdNameArry = new string[75];

        private void UserControlStdEdit_RemoveFromClass_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

 

        private void button13_Click(object sender, EventArgs e)
        {
            
                try
                {
                string constring = ConnectionString.constring;
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        con.Open();

                        using (DataTable dt = new DataTable("class_table"))
                        {
                            using (SqlCommand cmd = new SqlCommand($"SELECT studentID, firstName, lastName FROM student WHERE classID = @classID GROUP BY studentID, firstName, lastName", con))
                            {
                                cmd.Parameters.AddWithValue("@classID", txtCLID.Text);
                                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                                adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    dataGridViewStdRemove.Rows.Add(dt.Rows[i]["studentID"], dt.Rows[i]["firstName"], dt.Rows[i]["lastName"]);

                                }

                                    dataGridViewStdRemove.Refresh();
                                }
                                else
                                {
                                    MessageBox.Show("No students found for this class ID.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            



        }
        private void dataGridViewStdRemove_Load(object sender, EventArgs e)
        {
            
        }

        public void stdSearch(string stdToSearch, int classID)
        {
            string constring = ConnectionString.constring;
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                
            using (DataTable dt = new DataTable("student"))
                {
                    using (SqlCommand command = new SqlCommand($"SELECT studentID, firstName, lastName FROM student WHERE studentID = @stdToSearch AND classID = @classID", con))
                    {
                        command.Parameters.AddWithValue("@stdToSearch", stdToSearch);
                        command.Parameters.AddWithValue("@classID", classID);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                        dataAdapter.Fill(dt);
                        dataGridViewStdRemove.Rows.Clear();
                        if (dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                dataGridViewStdRemove.Rows.Add(dt.Rows[i]["studentID"], dt.Rows[i]["firstName"], dt.Rows[i]["lastName"]);
                            }

                            dataGridViewStdRemove.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("No students found for this class ID.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnStdSearch_Click(object sender, EventArgs e)
        {
            string stdToSearch = txtStdSearch.Text.Trim();
            int classID = int.Parse(txtCLID.Text);
            stdSearch(stdToSearch, classID);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string constring = ConnectionString.constring;
            using (SqlConnection con = new SqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string StuID = txtRemove.Text.Trim();
                    string query = $"UPDATE student SET classID = NULL WHERE classID = '{txtCLID.Text}' AND studentID = '{StuID}';";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@studentID", txtRemove.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student Removed Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No records were deleted. Check if the tuteID exists.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting data: {ex.Message}");

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = ConnectionString.constring;
            SqlConnection con = new SqlConnection(constring);
            try
            {
                using (con = new SqlConnection(constring))
                {
                    con.Open();

                    using (DataTable dt = new DataTable("class_table"))
                    {
                        using (SqlCommand cmd = new SqlCommand($"SELECT studentID, firstName, lastName FROM student WHERE classID = @classID GROUP BY studentID, firstName, lastName", con))
                        {
                            cmd.Parameters.AddWithValue("@classID", txtCLID.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                dataGridViewStdRemove.Rows.Clear();
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    dataGridViewStdRemove.Rows.Add(dt.Rows[i]["studentID"], dt.Rows[i]["firstName"], dt.Rows[i]["lastName"]);
                                }

                                dataGridViewStdRemove.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("No students found for this class ID.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
