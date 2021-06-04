using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.BasicDataTypes
{
    class BasicDataTypesVowelSwitch
    {
        static void Main(string[] args)
        {
            /*
            Create a program to ask the user for a symbol and answer 
            if it is a (lowercase)vowel, a digit, or any other symbol, using "switch".
            */
            char sign;

            Console.Write("Please select symbol: ");
            sign = Convert.ToChar(Console.ReadLine());

            switch (sign)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("(lowercase)vowel");
                    break;
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    Console.WriteLine("digit");
                    break;
                default:
                    Console.WriteLine("somethin else");
                    break;
            }

            Console.ReadLine();


        }
    }
}
