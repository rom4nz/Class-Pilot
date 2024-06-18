using Class_Pilot.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Reflection;

namespace Classpilot___PaymentReport02
{
    public partial class UserControlPayRepUnpaidStudents : UserControl
    {
        public UserControlPayRepUnpaidStudents()
        {
            InitializeComponent();
            lblNoData.Visible = false;
        }


        private void UserControlPayRepUnpaidStudents_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Global.classID, out int classID))
            {
                Console.WriteLine("Class ID: " + classID); 
                try
                {
                    string constring = ConnectionString.constring;

                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        con.Open();

                        using (DataTable dt = new DataTable("class_table"))
                        {
                            using (SqlCommand cmd = new SqlCommand(@"SELECT s.studentID, s.firstName, s.lastName
                            FROM student s
                            INNER JOIN class_table c ON s.classID = c.classID
                            LEFT JOIN payments p ON s.studentID = p.studentID AND c.classID = p.classID AND YEAR(p.date) = YEAR(GETDATE()) AND MONTH(p.date) = MONTH(GETDATE())
                            WHERE c.classID = @classID AND p.paymentID IS NULL
                            GROUP BY s.studentID, s.firstName, s.lastName;", con))
                            {
                                cmd.Parameters.AddWithValue("@classID", classID);
                                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                                adapter.Fill(dt);

                                if (dt.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dt.Rows.Count; i++)
                                    {
                                        dataGridView1.Rows.Add(dt.Rows[i]["studentID"], dt.Rows[i]["firstName"], dt.Rows[i]["lastName"]);
                                    }

                                    dataGridView1.Refresh();
                                }
                                else
                                {
                                    MessageBox.Show("No students found for this class ID.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Handle invalid class ID (optional)
            }
        }

        private void txtClassID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
