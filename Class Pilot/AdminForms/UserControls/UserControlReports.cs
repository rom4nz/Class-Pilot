using Class_Pilot.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Pilot
{
    public partial class UserControlReports : UserControl
    {
        [DllImport("gdi32.dll", EntryPoint = "CombineRgn")]
        private static extern int CombineRgn(IntPtr hrgnDest, IntPtr hrgnSrc1, IntPtr hrgnSrc2, int fnCombineMode);

        private bool stdEditCollapsed;
        private const int AnimationIncrement = 10;
        private const int AnimationInterval = 5;
        public UserControlReports()
        {
            InitializeComponent();
        }

        private void UserControlReports_Load(object sender, EventArgs e)
        {
            userControlTeacher1.Show();
            userControlStudent1.Hide();
            userControlTeacher1.BringToFront();

            this.Hide();
            pnlSel.Width = ButtonTeachR.Width - 160;
            pnlSel.Height = 5;
            pnlSel.Top = ButtonTeachR.Bottom - pnlSel.Height - 5;
            pnlSel.Left = ButtonTeachR.Left + 80;
            ButtonTeachR.BackColor = Color.FromArgb(66, 126, 243);
        }


        private void ButtonTeachR_Click(object sender, EventArgs e)
        {
            userControlStudent1.Hide();
            userControlTeacher1.Show();
            userControlTeacher1.BringToFront();

            pnlSel.Width = ButtonTeachR.Width - 160;
            pnlSel.Height = 5;
            pnlSel.Top = ButtonTeachR.Bottom - pnlSel.Height - 5;
            pnlSel.Left = ButtonTeachR.Left + 80;
            ButtonTeachR.BackColor = Color.FromArgb(66, 126, 243);
        }

        private void ButtonStudR_Click(object sender, EventArgs e)
        {
            userControlTeacher1.Hide();
            userControlStudent1.Show();
            userControlTeacher1.BringToFront();

            pnlSel.Width = ButtonStudR.Width - 160;
            pnlSel.Height = 5;
            pnlSel.Top = ButtonStudR.Bottom - pnlSel.Height - 5;
            pnlSel.Left = ButtonStudR.Left + 80;
            ButtonStudR.BackColor = Color.FromArgb(66, 126, 243);
        }
        private void ButtonTeachR_Leave(object sender, EventArgs e)
        {
            ButtonTeachR.BackColor = Color.FromArgb(66, 126, 243);
        }

        private void ButtonStudR_Leave(object sender, EventArgs e)
        {
            ButtonStudR.BackColor = Color.FromArgb(66, 126, 243);
        }

        private void pnlSel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
