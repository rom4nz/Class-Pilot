using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_Pilot;
using Class_Pilot.Classes;
using Microsoft.Data.SqlClient;

namespace Classpilot___PaymentReport02
{
    public partial class UserControlPayRepTotalEarnings : UserControl
    {
        public UserControlPayRepTotalEarnings()
        {
            InitializeComponent();
            txtClassID.Hide();
        }

        private void UserControlPayRepTotalEarnings_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewTotalEarnings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = ConnectionString.constring;
                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();
                    using (DataTable dataTable = new DataTable())
                    {
                      
                        string classID = Global.classID;
                        using (SqlCommand cmd = new SqlCommand($@"
              SELECT 
                  DATENAME(month, payments.date) AS Month, 
                  SUM(class_table.classFee) AS [Total Earnings]
              FROM 
                  payments
              INNER JOIN 
                  class_table ON payments.classID = class_table.classID
              WHERE 
                  class_table.classID = @classID
              GROUP BY 
                  DATENAME(month, payments.date)
              ORDER BY 
                  Month;"))
                        {
                            cmd.Connection = con; // Set connection for the command
                            cmd.Parameters.AddWithValue("@classID", classID);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dataTable);

                            dataGridViewTotalEarnings.Rows.Clear();
                            foreach (DataRow row in dataTable.Rows)
                            {
                                string month = row["Month"].ToString();
                                decimal earnings = decimal.Parse(row["Total Earnings"].ToString());
                                dataGridViewTotalEarnings.Rows.Add(month, earnings);
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

        private void txtClassID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
