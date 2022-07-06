using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilFirma
{
    class Department
    {
        private string name { get; set; }
        public List<Employee> Employees { get; private set; }

        public Department(string name, List<Employee> employees)
        {
            this.name = name;
            Employees = employees;
        }
    }
}
