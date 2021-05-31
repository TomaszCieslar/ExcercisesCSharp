using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.ArrayStructures
{
    class ArraysStructuresTwoDimensionalArray
    {
        static void Main(string[] args)
        {
            //Write a C# program to ask the user for marks for 20 pupils 
            //(2 groups of 10, using a two-dimensional array), and display the average for each group.


            float AvarageForGroupOne = 0;
            float AvarageForGroupTwo = 0;

            float SumOne = 0;
            float SumTwo = 0;

            float[,] ArrayOfPupils = new float[2, 10];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("Enter mark for group {0} pupil {1}: ", i + 1, j + 1);
                    ArrayOfPupils[i, j] = Convert.ToSingle(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0)
                    {
                        SumOne += ArrayOfPupils[i, j];
                        AvarageForGroupOne = SumOne / 10;
                    }
                    else
                    {
                        SumTwo += ArrayOfPupils[i, j];
                        AvarageForGroupTwo = SumTwo / 10;
                    }
                }
            }

            Console.WriteLine("Avarage for Group One: {0}", AvarageForGroupOne);
            Console.WriteLine("Avarage for Group Two: {0}", AvarageForGroupTwo);

            Console.ReadLine();

        }
    }
}
