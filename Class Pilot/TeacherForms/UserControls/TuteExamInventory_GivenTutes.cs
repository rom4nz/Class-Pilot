using Class_Pilot.Classes;
using Microsoft.Data.SqlClient;
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

namespace Class_Pilot
{

    public partial class TuteExamInventory_GivenTutes : UserControl
    {
        public TuteExamInventory_GivenTutes()
        {
            InitializeComponent();
        }

        private void btnTuteInventory_Click(object sender, EventArgs e)
        {

        }

        private void TuteExamInventory_GivenTutes_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnStuSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = ConnectionString.constring;
                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();

                    using (DataTable dt = new DataTable("class_table"))
                    {
                        using (SqlCommand cmd = new SqlCommand($"SELECT studentID, firstName FROM student WHERE classID = @classID GROUP BY studentID, firstName", con))
                        {
                            //cmd.Parameters.AddWithValue("@classID", txtCLID.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                dtGirdViewGivenTtues.Columns.Add("StudentID", "Student ID");
                                dtGirdViewGivenTtues.Columns.Add("FirstName", "First Name");
                                dtGirdViewGivenTtues.DataSource = dt;

                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    dtGirdViewGivenTtues.Rows[i].Cells[0].Value = dt.Rows[i]["studentID"];
                                    dtGirdViewGivenTtues.Rows[i].Cells[1].Value = dt.Rows[i]["firstName"];
                                }

                                dtGirdViewGivenTtues.Refresh();
                            }
                            else
                            {
                                /* MessageBox.Show("No students found for this class ID.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(Global.classID, out int classID))
                {
                    string constring = ConnectionString.constring;
                    Console.WriteLine($"Selected ClassID = {classID}");
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        con.Open();

                        using (DataTable dt = new DataTable("class_table"))
                        {
                            using (SqlCommand cmd = new SqlCommand(@"SELECT 
                                te.tuteID, 
                                te.tuteName, 
                                s.studentID, 
                                s.firstName,
                                s.lastName
                            FROM 
                                student_tutes st
                            JOIN 
                                tute_exam te ON st.tuteID = te.tuteID AND te.classID = @classID
                            JOIN 
                                student s ON st.studentID = s.studentID
                            WHERE 
                                st.tuteGiven = 1;", con))
                            {
                                cmd.Parameters.AddWithValue("@classID", classID);
                                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                                adapter.Fill(dt);

                                if (dt.Rows.Count > 0)
                                {
                                    dtGirdViewGivenTtues.Rows.Clear();
                                    for (int i = 0; i < dt.Rows.Count; i++)
                                    {
                                        dtGirdViewGivenTtues.Rows.Add(dt.Rows[i]["tuteID"], dt.Rows[i]["tuteName"], dt.Rows[i]["studentID"], dt.Rows[i]["firstName"], dt.Rows[i]["lastName"]);
                                    }

                                    dtGirdViewGivenTtues.Refresh();
                                }
                                else
                                {
                                    MessageBox.Show("No students found for this class ID.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Refresh();
        }
    }
}
