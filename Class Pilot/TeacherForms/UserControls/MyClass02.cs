using Class_Pilot;
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
using Class_Pilot.Classes;

namespace Classpilot___Myclass02
{
    public partial class MyClass02 : UserControl
    {

        public MyClass02()
        {
            InitializeComponent();
        }


        private void MyClass02_Load(object sender, EventArgs e)
        {
            this.Hide();
            txtClassID.Text = Global.classID;
            txtClassID.Hide();

        }

        private void MyClass02_Leave(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

                    using (DataTable dt = new DataTable("student"))
                    {
                        using (SqlCommand cmd = new SqlCommand($"SELECT firstName, lastName, phoneNo FROM student WHERE classID ={classID}", con))
                        {
                            cmd.Parameters.AddWithValue("@classID", classID);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                // Clear the DataGridView
                                dataGridView1.Rows.Clear();

                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    dataGridView1.Rows.Add(dt.Rows[i]["firstName"], dt.Rows[i]["lastName"], dt.Rows[i]["phoneNo"]);
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
        public void stdSearch(string stdToSearch, int classID)
        {
            string constring = ConnectionString.constring;
            using (SqlConnection con = new SqlConnection(constring))

            {
                con.Open();

                using (DataTable dataTable = new DataTable("student"))
                {
                    using (SqlCommand command = new SqlCommand($"SELECT studentID, firstName FROM student WHERE studentID = @stdToSearch AND ClassID = @classID GROUP BY studentID, firstName", con))
                    {
                        command.Parameters.AddWithValue("@stdToSearch", stdToSearch);
                        command.Parameters.AddWithValue("@classID", classID);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                        dataAdapter.Fill(dataTable);
                        if (dataTable.Rows.Count > 0)
                        {

                            for (int i = 0; i < dataTable.Rows.Count; i++)
                            {
                                dataGridView1.Rows[i].Cells[0].Value = dataTable.Rows[i]["studentID"];
                                dataGridView1.Rows[i].Cells[1].Value = dataTable.Rows[i]["firstName"];
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

        private void button13_Click(object sender, EventArgs e)
        {
            string stdtosearch = txtStdSearch.Text.Trim();
            int classid = int.Parse(Global.classID);
            stdSearch(stdtosearch, classid);
        }

        private void txtClassID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Global.classID = "0";
        }
    }
}
