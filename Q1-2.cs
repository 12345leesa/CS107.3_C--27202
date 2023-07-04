using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter  the  radius of the circle");
            double redius = Convert.ToDouble(Console.ReadLine());

            double area = CalculateCircleArea(radius);

            Console.WriteLine("the area of the circle is " +area);
            Console.ReadLine();


        }

        static double CalculateCircleArea(double radius)
        {

            double area = Math.PI * radius * radius;
            return area;

        }
    }
}
