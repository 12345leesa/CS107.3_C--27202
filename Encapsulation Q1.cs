using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("enter employee ID");
            var empID = int.Parse(Console.ReadLine());

            employee.EmpID = empID;

            Console.WriteLine("enter employee name");
            string empName = Console.ReadLine();
            employee.EmpName = empName;

            Console.WriteLine("enter employee Designation");
            string empDesignation = Console.ReadLine();
            employee.EmpDesignation = empDesignation;

            Console.WriteLine("hello, {0}! you Employee ID is {1} and you are a {2}", employee.EmpName, employee.EmpID, arg2: employee.EmpDesignation);
            Console.ReadLine();

        }
    }
}
