using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_2.Properties
{
    internal class FindValues
    {
        public double Findrea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }
        public double FindCirciference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }

    }
}
