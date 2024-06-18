using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classpilot___PaymentReport02
{
    internal class PaymentReport02
    {
        public int studentid { get; set; }
        public string studentname { get; set; }

        public PaymentReport02(int studentid, string studentname)
        {
            this.studentid = studentid;
            this.studentname = studentname;
        }
    }
}
