﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number == 0 )
            {
                Console.WriteLine("number is zero");
            }
            else if ( number%2 == 0 )
            {
                Console.WriteLine("number is even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }
            Console.ReadLine();
        }

    }
}
