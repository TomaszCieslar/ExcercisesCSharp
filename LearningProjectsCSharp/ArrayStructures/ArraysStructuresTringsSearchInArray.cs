using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.ArrayStructures
{
    class ArraysStructuresTringsSearchInArray
    {
        void Main(string[] args)
        {
            //            Create a program that says if a data belongs in a list that was previously created. 

            //The steps to take are:
            //            -Ask the user how many data will he enter. 
            //-Reserve space for that amount of numbers(floating point).
            //- Request the data to the user
            //- Later, repeat: 
            //*Ask the user for a number (execution ends when he enters "end" instead of a number). 
            //*Say if that number is listed or not.

            //Must be done in pairs.but you must provide a single source file, containing the names of both programmers in a comment.


            int NumberOfDigits;
            int SearchingNumber;

            Console.Write("Please indicate how many data will you enter: ");
            NumberOfDigits = int.Parse(Console.ReadLine());

            int[] Array = new int[NumberOfDigits];



            for (int i = 0; i < NumberOfDigits; i++)
            {
                Console.Write("Please indicate number {0}:", i + 1);
                Array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Please indicate number to search: ");
            SearchingNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < Array.Length; i++)
            {
                if (SearchingNumber == Array[i])
                {
                    Console.WriteLine("Number exist on position {0}: ", i + 1);
                }
            }

            Console.ReadLine();

        }
    }
}
