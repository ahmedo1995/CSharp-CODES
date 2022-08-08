using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Customer
    {
        public int Bvn { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int NIN { get; set; }
        public string Branch { get; set; }
        public int age { get; set; }

        public string Openaccount()
        {
            if (age >= 18)
            {
                return "You can now open your account";
            }
            else
            {
                return "You cannot open an account";
            }
        }

    }
}
