using Class_Pilot.Classes;
using System;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classpilot___PaymentReport02
{
    public partial class UserControlPayRepPaidStudents : UserControl
    {
        public UserControlPayRepPaidStudents()
        {
            InitializeComponent();
            this.Hide();
            lblNoData.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControlPayRepPaidStudents_Load(object sender, EventArgs e)
        {
            try
            {

                if (int.TryParse(Global.classID, out int classID))
                {
                    Console.WriteLine("Class ID: " + classID);
                    string constring = ConnectionString.constring;
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        con.Open();

                        using (DataTable dt = new DataTable("class_table"))
                        {
                            using (SqlCommand cmd = new SqlCommand(@"SELECT s.studentID, s.firstName, s.lastName
                                FROM payments p
                                JOIN student s ON p.studentID = s.studentID
                                JOIN class_table c ON p.classID = c.classID
                                WHERE c.classID = @classID AND YEAR(p.date) = YEAR(GETDATE()) AND MONTH(p.date) = MONTH(GETDATE());", con))
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
                                    lblNoData.Visible = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string classID = Global.classID;
                string constring = ConnectionString.constring;
                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();

                    using (DataTable dt = new DataTable("class_table"))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT s.studentID, s.firstName, s.lastName " +
                           "FROM payments p " +
                           "JOIN student s ON p.studentID = s.studentID " +
                           "JOIN class_table c ON p.classID = c.classID " +
                           "WHERE c.classID = @classID;", con))
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

        private void btnBack_Click(object sender, EventArgs e)
        {
          
        }
    }
}
