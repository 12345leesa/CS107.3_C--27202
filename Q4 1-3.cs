using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the kilometer value");
            double kilometer = Convert.ToDouble(Console.ReadLine());

            ConvertValues converter = new ConvertValues();
            double meter = converter.kilometetToMeter(kilometer);

            Console.WriteLine("equeation meter value is " +meter);

            Console.ReadLine();
        }
    }
}
