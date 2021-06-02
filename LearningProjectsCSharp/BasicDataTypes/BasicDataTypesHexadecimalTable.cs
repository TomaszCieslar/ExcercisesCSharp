using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.BasicDataTypes
{
    class BasicDataTypesHexadecimalTable
    {
        
        void Main(string[] args)
        {
            //Create a program to display the hexadecimal numbers from 0 to 255(decimal), 
            //in 16 rows with 16 numbers each(first row will contain the numbers 0 to 15 - decimal -, 
            //second will have 16 to 31 - decimal -, and so on). 

            for (int i = 0; i <= 255; i++)
            {
                if (i < 16)  // 0 in the beginning of the first row
                    Console.Write("0");

                Console.Write("{0} ",
                    Convert.ToString(i, 16));  // Hexadecimal

                if (i % 16 == 15)    // Jump to next line after 16 data
                    Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
