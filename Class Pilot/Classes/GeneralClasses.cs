using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Pilot.Classes
{
    public class GeneralClasses
    {
        public void Logout(Form form)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Logout", "Confirmation Message",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(check == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                form.Hide();
            }
        }
    }

    
}
