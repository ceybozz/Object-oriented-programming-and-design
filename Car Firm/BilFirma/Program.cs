using System;
using System.Collections.Generic;

namespace BilFirma
{
    class Program
    {
        static void Main(string[] args)
        {
            var e1 = new Employee("Kalle", 4, "Sales");
            var e2 = new Employee("Rohan", 2, "Mechanic");
            var e3 = new Employee("Mohammed", 3, "Sales");
            var e4 = new Employee("Abraham", 1, "CEO");
            var e5 = new Employee("Bertil", 5, "Mechanic");

            // Making a list of emplyees at the Sales depratment
            List<Employee> salesEmployees = new();
            salesEmployees.Add(e1);
            salesEmployees.Add(e3);

            // Making a list of employees at the mechanics department
            List<Employee> mechEmployees = new();
            mechEmployees.Add(e2);
            mechEmployees.Add(e5);

            // Making a list of employees at the CEO department
            List<Employee> ceoEmployees = new();
            ceoEmployees.Add(e4);

            // Creating departments
            var mech = new Department("Mechanic", mechEmployees);
            var sales = new Department("Sales", salesEmployees);
            var ceo = new Department("CEO", ceoEmployees);

            // Creating a list of the departments
            List<Department> departments = new();
            departments.Add(mech);
            departments.Add(sales);
            departments.Add(ceo);

            // Creating a Firm
            var f1 = new Firm("QC","Kungsgatan 10", "qualitycars.se", "9900-4565", departments);

            // Creating Prints, komplitering
            Console.WriteLine(f1);
            Console.WriteLine($"Total number of employees in Firm: " +
                                $"{f1.GetNumberOfEmplyeesInFirm()}");
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);
            Console.WriteLine(e4);
            Console.WriteLine(e5);
        }
    }
}
