using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilFirma
{
    class Employee
    {
        private string name { get; set; }
        private int id { get; set; }
        private string department { get; set; }

        public Employee(string name, int id, string dept)
        {
            this.name = name;
            this.id = id;
            this.department = dept;
        }

        // komplitering
        public override string ToString()
        {
            return "Employee: " + name + " has ID: " + id + " and works in " + department;
        }
    }
}
