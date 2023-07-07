using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string input = Console.ReadLine();

            int vowelCount = CountVowels(input);

            Console.WriteLine("numbers of vowels " +vowelCounnt);

            Console.ReadLine();

        }
        static int CountVowels(string input)
        {
            int count = 0;

            foreach (char c in input )
            {
                if (IsVowel(c))
                {
                    count++;
                }
            }
            return count;

        }
        static bool IsVowel(char c)
        {
            char lowerC = char.ToLower(c);
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach (char vowel in vowels)

            {
                if(lowerC == vowel)
                {
                    return true;
                }
            }
            return false;
        }
        
               
            
            

    }
}
