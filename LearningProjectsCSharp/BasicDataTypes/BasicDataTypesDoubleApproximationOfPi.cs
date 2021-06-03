using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.BasicDataTypes
{
    class BasicDataTypesDoubleApproximationOfPi
    {
        void Main(string[] args)
        {
            int terms;
            double result = 0;

            Console.WriteLine("PI estimator!");
            Console.Write("Enter the amount of terms to test: ");
            terms = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= terms; i++)
            {
                int divisor = 2 * i - 1;
                if (i % 2 == 1)
                    result += 1.0f / divisor;
                else
                    result -= 1.0f / divisor;

                Console.WriteLine("To term {0}: {1}",
                  i, 4 * result);
            }

            Console.ReadLine();
        }
    }
}
