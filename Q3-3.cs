using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter the number ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = CalculateDigitSum(number);

            Console.WriteLine("sum of the digits" +sum);

            Console.ReadLine();
        }
        static int CalculateDigitSum(int number)
        {
            int sum = 0;
             while (number != 0)
            {
                int digit = number % 10;
                sum = sum + digit;
                number = number / 10;
            }
            return sum;

            
        }
        

    }
}
