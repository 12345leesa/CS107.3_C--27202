using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab5_Q5.Properties
{
    internal class ArrayOperations
    {
        private string averageValue;
        private object reverseArray;

        public void PerformArrayOperations(int[] array, int[] reverseArray)
        {
            int minValue = FindMinimumValue(array);
            int maxValue = FindMaximumValue(array);
            int[] reverseArray = reverseArray(array);

            Console.WriteLine("Minimum value" +minValue);
            Console.WriteLine("Maximum value" +maxValue);
            Console.WriteLine("Average valu" +averageValue);
            Console.WriteLine("Reversed array");

            foreach (int num in reverseArray)
            {
                Console.WriteLine(num + " ");
            }

        
        }

        private int FindMinimumValue(int[] array)
        {
            throw new NotImplementedException();
        }

        private int FindMInimumValue(int[] array)
        {
            int minValue = array[0];

            for (int i =1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }
            return minValue;
        }
         private int FindMaximumValue(int[] array)
        {
            int maxValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }
        private double FindAverageValue (int[] array)
        {
            int sum = 0;

            foreach (int num in array)
            {
                sum = sum + num;
            }
            double average = (double)sum / array.Length;
            for (int i = 0; i < array.Length; ++i)
            {
                reverseArray = array[array.Length - 1 - i];
            }
            return (double)reverseArray;
        }
    }   
}

