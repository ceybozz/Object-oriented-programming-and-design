using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilFirma
{
    class Firm
    {
        private string name { get; set; }
        private string address { get; set; }
        private string url { get; set; }
        private string orgnr { get; set; }

        private List<Department> departments;

        public Firm(string name,string address, string url, string orgnr, List<Department> departments)
        {
            this.name = name;
            this.address = address;
            this.url = url;
            this.orgnr = orgnr;
            this.departments = departments;
        }

        // Komplitering
        public override string ToString()
        {
            return "Firm Name: " + name + ", address: " + address + ", URL: " + url + ", Org number: " + orgnr;
        }

        public int GetNumberOfEmplyeesInFirm()
        {
            int noOfEmployees = 0;
            List<Employee> employees;

            foreach (Department dept in departments)
            {
                employees = dept.Employees;
                foreach (var employee in employees)
                {
                    noOfEmployees++;
                }
            }
            return noOfEmployees;
        }
    }
}
