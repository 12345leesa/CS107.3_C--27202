using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("select an operation");
            Console.WriteLine("1.add");
            Console.WriteLine("2.sub");
            Console.WriteLine("3.mul");
            Console.WriteLine("4.divi");

            Console.WriteLine("enter your choice (1-4)");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the firts number ");
            double num1 = Convert.ToDouble(Console.ReadLine());
   
            Console.WriteLine("enter the second number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            CalculateValues calculate = new CalculateValues();
            double results = 0;

            switch(choice)
            {
                case 1:
                    results = calculate.add(num1, num2);
                    Console.WriteLine(" result of add is " +add);
                    break;
                case 2:
                    results = calculate.sub(num1, num2);
                    Console.WriteLine("result of sub is " +sub);
                    break;
                case 3:
                    results = calculate.mul(num1, num2);
                    Console.WriteLine("result is mul is " +mul);
                    break;
                case 4:
                    results = calculate.divi(num1, num2);
                    Console.WriteLine("result is divi is " +divi);
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;

            }
            Console.ReadLine();


        }
    }
}
