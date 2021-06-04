using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.BasicDataTypes
{
    class BasicDataTypesCharFor
    {
        static void Main(string[] args)
        {
            /*
            Create a program to write the letters "B" to "N"(uppercase), using "for"
            */


            for (char sign = 'B'; sign <= 'N'; sign++)
            {
                Console.WriteLine(sign);
            }

            Console.ReadLine();
        }
    }
}
