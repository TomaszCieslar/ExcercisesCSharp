using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.BasicDataTypes
{
    class BasicDataTypesDisplayaFunction
    {
        void Main(string[] args)
        {
            /*
            Create a program to "draw" the graphic of the function y = (x - 4)2 for integer values of x ranging - 1 to 8.
            It will show as many asterisks on screen as the value obtained for "y", like this: 
           *************************
           ****************
           *********
           ****
           *
           *
           ****
           *********
           ****************
           * */

            int x;
            int y;

            for (x = -1; x <= 8; x++)
            {
                y = (x - 4) * 2;

                for (int i = 1; i <= Math.Abs(y); i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
