using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access
{
    public class Employer
    {
        private int Empid { get; set; }
        private string Empfio { get; set; }
        private string Address { get; set; }
        private int Depid { get; set; }
        private decimal Salary { get; set; }

        public Employer(int empid, string empfio, string address, int depid, decimal salary)
        {
            this.Empid = empid;
            this.Empfio = empfio;
            this.Address = address;
            this.Depid = depid;
            this.Salary = salary;
        }
    }
}
