using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.BasicDataTypes
{
    class BasicDataTypesBinary
    {
        void Main(string[] args)
        {
            //Create a program that asks the user for a decimal number and displays its equivalent 
            //in binary form.It should be repeated until the user enters the word "end." You must not 
            //use "ToString", but succesive divisions.

            string answer;
            string result;
            do
            {
                Console.Write("Number to convert (or \"end\")? ");
                answer = Console.ReadLine();

                if (answer != "end")
                {
                    int n = Convert.ToInt32(answer);
                    result = "";
                    while (n > 1)
                    {
                        int remainder = n % 2;
                        result = Convert.ToString(remainder) + result;
                        n /= 2;
                    }
                    result = Convert.ToString(n) + result;
                    Console.WriteLine("Binary: {0}", result);
                }
            }
            while (answer != "end");

        }
    }
}
