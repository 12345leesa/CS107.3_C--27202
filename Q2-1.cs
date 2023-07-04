using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter the first number");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;

            Console.WriteLine("sum is " +sum);

            Console.ReadLine();
        }
    }
}
