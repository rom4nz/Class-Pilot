using Class_Pilot.Classes;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Windows.Forms;


namespace Class_Pilot
{
    public partial class Tute_ExamePaperSubmission : UserControl
    {
        readonly string[] tuNameArray = new string[75];
        int classID;

        public Tute_ExamePaperSubmission()
        {
            InitializeComponent();
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
                    string query = "SELECT tuteID FROM tute_exam ORDER BY tuteID Desc";
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
                    txtExamID.Text = clid.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connection.Close(); }
            }
        }

        private void ClearFields()
        {
            txtTuteName.Text = "";
            txtTutorID.Text = "";
            txtTutorName.Text = "";
            numericQuantity.Value = 1;
            comboBox1.Text = "";    
            comboBox1.Items.Clear();
        }


        private void Tute_ExamePaperSubmission_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {

            Delete_TuteExamPaper form = new Delete_TuteExamPaper();
            form.ShowDialog();



        }



        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtTutorName.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please Provide a tute/exam paper name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string constring = ConnectionString.constring;
            using (SqlConnection con = new SqlConnection(constring))
            {
                try
                {
                    con.Open();
                    int TutorID = int.Parse(txtTutorID.Text);
                    string TuteName = txtTuteName.Text;
                    int Quanitiy = int.Parse(numericQuantity.Text);
                    Console.WriteLine(classID);
                    string query = $"INSERT INTO tute_exam(tutorID, classID, tuteName, qty) VALUES({TutorID}, {classID}, '{TuteName}',{Quanitiy});";
                    SqlCommand cmd = new SqlCommand(query, con);
                    int i = cmd.ExecuteNonQuery();
                    if (i > -1)
                    {
                        MessageBox.Show("Tute added Successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (txtTutorID.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please Provide a tutor ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string constring = ConnectionString.constring;
            using (SqlConnection connection = new SqlConnection(constring))
            {
                //Get Techer Name
                try
                {
                    connection.Open();
                    string query = $"SELECT firstName, lastName FROM teacher WHERE tutorID = '{txtTutorID.Text}'";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    SqlDataReader reader = cmd.ExecuteReader();
                    bool hasData = false;
                    while (reader.Read())
                    {
                        hasData = true;
                        tuNameArray[0] = reader.GetString(reader.GetOrdinal("firstName"));
                        tuNameArray[1] = reader.GetString(reader.GetOrdinal("lastName"));
                    }
                    if (!hasData)
                    {
                        MessageBox.Show("No data found for this tutor ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    txtTutorName.Text = tuNameArray[0] + " " + tuNameArray[1];
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connection.Close(); }

                //Get Class Name
                try
                {
                    connection.Open();
                    string query = $"SELECT className FROM class_table WHERE tutorID = '{txtTutorID.Text}';";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader.GetString(0));
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connection.Close(); }

                

            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //Get Class ID
            string constring = ConnectionString.constring;
            using (SqlConnection connection = new SqlConnection(constring))
            {
                try
                {
                    connection.Open();
                    string query = $"SELECT classID FROM class_table WHERE className = '{comboBox1.Text}';";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        classID = reader.GetInt32(0);
                        Console.WriteLine(classID);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connection.Close();}
            }
        }
    }
}