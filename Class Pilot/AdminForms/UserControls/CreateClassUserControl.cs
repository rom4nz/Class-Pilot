using System;
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
    public partial class CreateClassUserControl : System.Windows.Forms.UserControl
    {
        
        public CreateClassUserControl()
        {
            InitializeComponent();
        }
        string Language = "";
        readonly string[] tuNameArry = new string[75];




        private void CreateClassUserControl_Load(object sender, EventArgs e)
        {
            this.Hide();
            GetClassID();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTuID.Text) || string.IsNullOrEmpty(txtClName.Text) ||
                string.IsNullOrEmpty(txtSub.Text) || string.IsNullOrEmpty(txtClFee.Text) ||
                string.IsNullOrEmpty(comboBoxGrade.Text) || string.IsNullOrEmpty(Language))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string constring = ConnectionString.constring;
            using (SqlConnection con = new SqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string classID = txtClassId.Text;
                    string tutorID = txtTuID.Text;
                    string className = txtClName.Text;
                    string subject = txtSub.Text;
                    string grade = comboBoxGrade.Text;
                    string classFee = txtClFee.Text;


                    string query = $"INSERT INTO class_table(tutorID, className, subject, grade, medium,  classFee) VALUES({tutorID},'{className}', '{subject}','{grade}', @Language, {classFee});";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Language", Language);




                    int i = cmd.ExecuteNonQuery();
                    if (i > -1)
                    {
                        MessageBox.Show("Created the Class Successfully","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ClearFields();
                    GetClassID();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void ClearFields()
        {
            txtTuID.Text = "";
            txtTuName.Text = "";
            txtClName.Text = "";
            txtSub.Text = "";
            comboBoxGrade.SelectedIndex = -1;
            txtClFee.Text = "";
            radioButtonSinhala.Checked = false;
            radioButtonEnglish.Checked = false;
        }

        private void radioButtonSinhala_CheckedChanged(object sender, EventArgs e)
        {
            Language = "Sinhala";
        }

        private void radioButtonEnglish_CheckedChanged(object sender, EventArgs e)
        {
            Language = "English";
        }
        
        private void button13_Click(object sender, EventArgs e)
        {
            string constring = ConnectionString.constring;
            using (SqlConnection connection = new SqlConnection(constring))
            {
                try
                {
                    connection.Open();

                    string query = $"SELECT firstName, lastName FROM teacher WHERE tutorID = '{txtTuID.Text}'";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("The typed userID is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    while (reader.Read())
                    {
                        tuNameArry[0] = reader.GetString(reader.GetOrdinal("firstName"));
                        tuNameArry[1] = reader.GetString(reader.GetOrdinal("lastName"));
                    }
                    txtTuName.Text = tuNameArry[0] + " " + tuNameArry[1];
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connection.Close(); }
            }

            GetClassID();

        }
        public void GetClassID()
        {
            string clid;
            string constring = ConnectionString.constring;
            using (SqlConnection connection = new SqlConnection(constring))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT classID FROM class_table ORDER BY classID Desc";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int id = int.Parse(reader[0].ToString()) + 1;
                        clid = id.ToString("00000");
                    }
                    else if (Convert.IsDBNull(reader))
                    {
                        clid = ("00001");
                    }
                    else
                    {
                        clid = ("00001");
                    }
                    txtClassId.Text = clid.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connection.Close(); }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTuID.Text = "";
            txtTuName.Text = "";
            txtClName.Text = "";
            txtSub.Text = "";
            comboBoxGrade.SelectedIndex = -1;
            txtClFee.Text = "";
            radioButtonSinhala.Checked = false;
            radioButtonEnglish.Checked = false;
        }
    }
}
