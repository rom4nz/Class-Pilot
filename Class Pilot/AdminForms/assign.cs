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
    public partial class assign : Form
    {
        public assign(string tutorID, string classID) // Constructor with both arguments
    {
        InitializeComponent();
       

        textBox1.Text = tutorID; // Set textBox1 with tutorID
        textBox2.Text = classID; // Set textBox2 with classID
    }


        private void btnassign_Click(object sender, EventArgs e)
        {
            string constring = ConnectionString.constring;
            SqlConnection con = new SqlConnection(constring);
          
            string updateQuery = $"UPDATE class_table SET   tutorID = '{textBox1.Text}' WHERE classID='{textBox2.Text}'" ;
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void assign_Load(object sender, EventArgs e)
        {
            
        }
    }
}
