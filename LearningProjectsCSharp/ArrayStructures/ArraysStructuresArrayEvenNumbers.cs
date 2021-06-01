using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.ArrayStructures
{
    class ArraysStructuresArrayEvenNumbers
    {
        void Main(string[] args)
        {
            // Write a C# program to ask the user for 10 integer numbers and display the even ones.

            int NumberOfNumbers = 10;
            int[] ArrayOfNumbers = new int[10];


            for (int i = 0; i < NumberOfNumbers; i++)
            {
                Console.Write("Please indicate number {0}: ", i + 1);
                ArrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < ArrayOfNumbers.Length; i++)
            {
                if (ArrayOfNumbers[i] % 2 == 0)
                {
                    Console.WriteLine(ArrayOfNumbers[i]);
                }
            }

            Console.ReadLine();

        }
    }
}
