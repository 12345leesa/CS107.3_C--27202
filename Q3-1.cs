using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter an integer");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number%2 == 0)
            {
                Console.WriteLine("even");

            }
            else
            {
                Console.WriteLine("odd");
            }

            Console.ReadLine();
        }
    }
}
