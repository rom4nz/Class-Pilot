using Class_Pilot;
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

namespace Teacher_Admin_Panel___Side_menu
{
    public partial class Teacher_StudentMarksTable : UserControl
    {
        public Teacher_StudentMarksTable()
        {
            InitializeComponent();
            SqlDataAdapter adapter;
            DataTable dt;
          

        }

        private void Teacher_StudentMarksTable_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddMarks_Click(object sender, EventArgs e)
        {
            AddMarks form = new AddMarks();
            form.ShowDialog();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string ClassID = Global.classID;
            string constring = ConnectionString.constring;
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string selectQuery = $"SELECT * FROM student_marks WHERE studentID= @studentID AND classID= {ClassID}";

             SqlCommand command = new SqlCommand(selectQuery, con);
            command.Parameters.AddWithValue("studentID",txtsearch.Text);

            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridViewStdMarks.DataSource=table;
            con.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Create a new instance of the UserControl
            Teacher_StudentMarksDashboard userControl = new Teacher_StudentMarksDashboard();

            // Add the UserControl to the parent control of the current UserControl
            this.Parent.Controls.Add(userControl);

            // Show the UserControl and bring it to front
            userControl.Show();
            userControl.BringToFront();
            this.Hide();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string ClassID = Global.classID;
            string constring = ConnectionString.constring;
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            // Replace with your actual SQL query to retrieve all student marks
            string sqlQuery = "SELECT * FROM student_marks";

            // Use MySqlDataAdapter and MySqlCommand for MySQL connection
            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridViewStdMarks.DataSource = dt;
            dataGridViewStdMarks.AutoGenerateColumns = true;

            con.Close();
        }
    }
}