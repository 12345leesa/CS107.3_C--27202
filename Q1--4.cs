using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter the emloyee salary");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the tax rate(in decimal form )");
            double taxRate = Convert.ToDouble(Console.ReadLine());

            double salaryAfterTax = salary * (1- taxRate);
            Console.WriteLine(" salary after tax " +salaryAfterTax);

            Console.ReadLine();
        }
    }
}
