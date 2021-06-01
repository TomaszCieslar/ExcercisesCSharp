using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.ArrayStructures
{
    class ArraysStructuresTringsReverseArray
    {
        void Main(string[] args)
        {
            // Create a program to ask the user for 5 numbers, store them in an array and show them in reverse order.

            int[] Array = new int[5];

            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("Podaj liczbe {0}: ", i + 1);
                Array[i] = Convert.ToInt16(Console.ReadLine());
            }



            for (int i = Array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(Array[i]);
            }

            Console.ReadLine();

        }
    }
}
