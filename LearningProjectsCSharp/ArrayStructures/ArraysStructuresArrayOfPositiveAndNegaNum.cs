using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.ArrayStructures
{
    class ArraysStructuresArrayOfPositiveAndNegaNum
    {
        void Main(string[] args)
        {
            //Create a C# program to ask the user for 10 real numbers 
            //and display the average of the positive ones and the average of the negative ones.

            int NumberOfNumbers = 10;
            int[] Array = new int[NumberOfNumbers];

            int SumOfPositive = 0;
            int SumOfNegative = 0;

            int NumberOfPositive = 0;
            int NumberOfNegative = 0;

            for (int i = 0; i < NumberOfNumbers; i++)
            {
                Console.Write("Please indicate number {0}: ", i + 1);
                Array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] >= 0)
                {
                    NumberOfPositive++;
                    SumOfPositive += Array[i];
                }
                else
                {
                    NumberOfNegative++;
                    SumOfNegative += Array[i];
                }
            }

            Console.WriteLine("Avarage of positive: {0}", SumOfPositive / NumberOfPositive);
            Console.WriteLine("Avarage of negative: {0}", SumOfNegative / NumberOfNegative);

            Console.ReadLine();


        }
    }
}
