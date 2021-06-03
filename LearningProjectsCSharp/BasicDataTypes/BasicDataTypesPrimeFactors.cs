using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.BasicDataTypes
{
    class BasicDataTypesPrimeFactors
    {
        void Main(string[] args)
        {
            int n;
            int d = 2;

            Console.Write("Enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n > 1)
            {
                while (n % d == 0)
                {
                    Console.Write(d);
                    Console.Write(" · ");
                    n = n / d;
                }

                d++;
            }
            Console.Write(1);

            Console.ReadLine();
        }
    }
}
