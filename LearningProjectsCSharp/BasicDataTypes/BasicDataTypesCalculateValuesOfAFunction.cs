using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.BasicDataTypes
{
    class BasicDataTypesCalculateValuesOfAFunction
    {
        static void Main(string[] args)
        {
            /*
           Create a program to display certain values of the function y = x2 - 2x + 1
               (using integer numbers for x, ranging from - 10 to + 10)
           */

            double y = 0;

            Console.WriteLine("y = x2 - 2x + 1");
            Console.WriteLine();


            for (int x = -10; x <= 10; x++)
            {
                y = (long)Math.Pow(x, 2) - (2 * x) + 1;
                Console.WriteLine("x = {0}, y = {0}^2 - 2*{0} + 1 = {1}", x, y);
            }

            Console.ReadLine();
        }
    }
}
