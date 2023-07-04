using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter the first number");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" enter the second number");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double sum = number1 + number2;
            double sub = number1 - number2;
            double mul = number1 * number2;
            double divi = number1 - number2;

            Console.WriteLine(" sum is " +sum);
            Console.WriteLine(" sub is " +sub);
            Console.WriteLine(" mul is " +mul);
            Console.WriteLine("divi is " +divi);

            Console.ReadLine();




        }
    }
}
