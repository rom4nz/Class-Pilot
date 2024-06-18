using Class_Pilot.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Class_Pilot
{
    public partial class TuteExamInventory_TuteInventory : System.Windows.Forms.UserControl
    {
        public TuteExamInventory_TuteInventory()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonStudR_Click(object sender, EventArgs e)
        {
        }

        private void TuteExamInventory_TuteInventory_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
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
                                te.qty - ISNULL(COUNT(st.tuteGiven), 0) AS QuantityRemaining,
                                ISNULL(COUNT(st.tuteGiven), 0) AS QuantityGiven
                                FROM
                                    tute_exam te
                                LEFT JOIN
                                    student_tutes st ON te.tuteID = st.tuteID AND st.tuteGiven = 1
                                WHERE
                                     te.classID = @classID
                                GROUP BY
                                    te.tuteID, te.tuteName, te.qty;", con))
                            {
                                cmd.Parameters.AddWithValue("@classID", classID);
                                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                                adapter.Fill(dt);

                                if (dt.Rows.Count > 0)
                                {
                                    dataGridView1.Rows.Clear();
                                    for (int i = 0; i < dt.Rows.Count; i++)
                                    {
                                        dataGridView1.Rows.Add(dt.Rows[i]["tuteID"], dt.Rows[i]["tuteName"], dt.Rows[i]["QuantityRemaining"], dt.Rows[i]["QuantityGiven"]);
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
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Refresh();
        }
    }
}
