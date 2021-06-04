using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.BasicDataTypes
{
    class BasicDataTypesVowelIf
    {
        static void Main(string[] args)
        {
            /*
             * Create a program to ask the user for a symbol and answer if it is a (lowercase) vowel, a digit, or any other symbol, using "if".
             */

            char sign;

            Console.Write("Please select symbol: ");
            sign = Convert.ToChar(Console.ReadLine());

            if (sign == 'a' || sign == 'e' || sign == 'i' || sign == 'o' || sign == 'u')
            {
                Console.WriteLine("(lowercase)vowel");
            }
            else if (sign >= '0' && sign <= '9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("somethin else");
            }


            Console.ReadLine();

        }
    }
}
