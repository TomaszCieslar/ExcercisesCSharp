using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.BasicDataTypes
{
    class BasicDataTypesExceptions
    {
        void Main(string[] args)
        {

            //Create a program to ask the user for a real number 
            //and display its square root.Errors must be trapped using "try..catch".

            float result;
            float num;

            Console.Write("Enter Number ");
            try
            {
                num = Convert.ToSingle(Console.ReadLine());

                result = (float)Math.Sqrt(num);
                Console.WriteLine("The result is: {0}", result);
            }
            catch (Exception)
            {
                Console.WriteLine("Error, I cannot calculate the Square Root");
            }

            Console.ReadLine();
        }
    }
}
