using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Class_Pilot.Classes;


namespace Class_Pilot.UserControls
{
    public partial class UserControlTeacher : System.Windows.Forms.UserControl
    {
        public UserControlTeacher()
        {
            InitializeComponent();
        }

        private void UserControlTeacher_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string conString = ConnectionString.constring;
            try
            {
                using (SqlConnection cn = new SqlConnection(conString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (DataTable dt = new DataTable("class_table"))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT c.classID, c.className, COUNT(p.date) * c.classFee AS income FROM class_table c LEFT JOIN payments p ON c.classID = p.classID WHERE tutorID=@tutorID GROUP BY c.classID, c.className, c.classFee", cn))
                        {
                            cmd.Parameters.AddWithValue("@tutorID", txtSearch.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Invalid ID, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            double sum = 0;
                            for (int i = 0; i < dt.Rows.Count; ++i)
                            {
                                sum += Convert.ToDouble(dt.Rows[i][2]);
                            }

                            dt.Rows.Add(dt.NewRow());

                            // Add a new row to the DataTable
                            DataRow newRow = dt.NewRow();
                            newRow[1] = "**Total Income**";
                            newRow[2] = sum;
                            dt.Rows.Add(newRow);

                            dataGridViewT.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//enter
                btnSearch.PerformClick();
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            string conString = ConnectionString.constring;
            try
            {
                using (SqlConnection cn = new SqlConnection(conString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();

                    using (DataTable dt = new DataTable())
                    {
                        // Use the correct table name (e.g., "payments")
                        using (SqlCommand cmd = new SqlCommand("SELECT c.classID, c.className, COUNT(p.date) * c.classFee AS income FROM class_table c LEFT JOIN payments p ON c.classID = p.classID WHERE tutorID=@tutorID AND p.date BETWEEN @startdate AND @enddate GROUP BY c.classID, c.className, c.classFee", cn))
                        {
                            // Add parameters for date range
                            cmd.Parameters.AddWithValue("@startdate", dtStartDate.Value);
                            cmd.Parameters.AddWithValue("@enddate", dtEndDate.Value);
                            cmd.Parameters.AddWithValue("@tutorID", txtSearch.Text);

                            // Fill data into DataTable
                            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                            sqlDataAdapter.Fill(dt);

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Select Start Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            double sum = 0;
                            for (int i = 0; i < dt.Rows.Count; ++i)
                            {
                                sum += Convert.ToDouble(dt.Rows[i][2]);
                            }

                            dt.Rows.Add(dt.NewRow());

                            // Add a new row to the DataTable
                            DataRow newRow = dt.NewRow();
                            newRow[1] = "**Total Income**";
                            newRow[2] = sum;
                            dt.Rows.Add(newRow);

                            dataGridViewT.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Tutor Report.pdf";
            bool fileError = false;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);
                    }
                    catch (IOException ex)
                    {
                        fileError = true;
                        MessageBox.Show("It wasn't possible to write the data to disk." + ex.Message);
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        PdfPTable pdfTable = new PdfPTable(dataGridViewT.ColumnCount);
                        pdfTable.DefaultCell.Padding = 7;
                        pdfTable.DefaultCell.BorderWidth = 1;
                        pdfTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                        foreach (DataGridViewColumn column in dataGridViewT.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 192, 192);
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.VerticalAlignment = Element.ALIGN_CENTER;
                            cell.Padding = 7;
                            cell.BorderWidth = 1;
                            pdfTable.AddCell(cell);
                        }

                        foreach (DataGridViewRow row in dataGridViewT.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfTable.AddCell(cell.Value.ToString());
                            }
                        }

                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();

                            // Create a table with two columns
                            PdfPTable table = new PdfPTable(2);
                            table.WidthPercentage = 100; // full width

                            // Add Logo to PDF
                            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                            string imagePath = Path.Combine(projectDirectory, "Class Pilot\\Resources", "PDF Logo.png");
                            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(imagePath);
                            jpg.ScaleToFit(200f, 200f);
                            PdfPCell imageCell = new PdfPCell(jpg);
                            imageCell.Border = PdfPCell.NO_BORDER;
                            table.AddCell(imageCell);

                            // Create a cell for the paragraphs and add them
                            PdfPCell textCell = new PdfPCell();
                            textCell.Border = PdfPCell.NO_BORDER;

                            // Add date
                            Paragraph paragraph = new Paragraph();
                            paragraph.Add(new Chunk("Issued Date - " + DateTime.Now.ToShortDateString()));
                            paragraph.Alignment = Element.ALIGN_RIGHT;
                            paragraph.Font = FontFactory.GetFont(FontFactory.HELVETICA, 13f, BaseColor.BLACK);
                            paragraph.SpacingBefore = 3f;
                            paragraph.SpacingAfter = 3f;
                            textCell.AddElement(paragraph);

                            // Add tutor ID
                            paragraph = new Paragraph();
                            paragraph.Add(new Chunk("Tutor ID - " + txtSearch.Text)); // Replace with actual tutor ID
                            paragraph.Alignment = Element.ALIGN_RIGHT;
                            paragraph.Font = FontFactory.GetFont(FontFactory.HELVETICA, 13f, BaseColor.BLACK);
                            textCell.AddElement(paragraph);

                            // Add the text cell to the table
                            table.AddCell(textCell);
                            table.SpacingAfter = 30f;

                            // Add the table to the document
                            pdfDoc.Add(table);

                            // Create a table with one column for the title
                            PdfPTable titleTable = new PdfPTable(1);
                            titleTable.WidthPercentage = 100; // full width

                            // Create a cell for the title
                            PdfPCell titleCell = new PdfPCell();
                            titleCell.Border = PdfPCell.NO_BORDER;

                            // Add title
                            paragraph = new Paragraph();
                            paragraph.Add(new Chunk("**Tutor Income Report**")); // Replace with actual tutor ID
                            paragraph.Alignment = Element.ALIGN_CENTER;
                            paragraph.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18f, BaseColor.BLACK);
                            paragraph.SpacingAfter = 20f;
                            titleCell.AddElement(paragraph);

                            // Set spacing before the next element
                            pdfTable.SpacingBefore = 10f;

                            // Add start and end date
                            paragraph = new Paragraph();
                            paragraph.Add(new Chunk("Income between " + dtStartDate.Value.ToString("MM/dd/yyyy") + " and " + dtEndDate.Value.ToString("MM/dd/yyyy")));
                            paragraph.Alignment = Element.ALIGN_LEFT;
                            paragraph.Font = FontFactory.GetFont(FontFactory.HELVETICA, 13f, BaseColor.BLACK);
                            titleCell.AddElement(paragraph);

                            // Add the title cell to the table
                            titleTable.AddCell(titleCell);

                            // Add the title table to the document
                            pdfDoc.Add(titleTable);

                            pdfDoc.Add(pdfTable);
                            pdfDoc.Close();
                            stream.Close();
                        }

                        MessageBox.Show("Successfully Saved As PDF !!!", "Info");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }
            }
        }

    }
}
