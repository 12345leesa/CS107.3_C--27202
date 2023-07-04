using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Q2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the radius of the circle");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = CalculateCircleArea(radius);
            double circumference = CalculateCircleCircumference(radius);

            Console.WriteLine("area of the circle " +area);
            Console.WriteLine("Circumference of the circle " +circumference);

            Console.ReadLine();

        }

        static double CalculateCirclrArea(double radius)
        {
          double area = Math.PI * radius * radius;
          return area;
        }

        static double CalculateCircleCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }
       
    }  


}
