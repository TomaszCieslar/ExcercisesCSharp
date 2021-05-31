using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningProjectsCSharp.ArrayStructures
{
    class ArraysStructuresStatistics
    {
        static void Main(string[] args)
        {
            
            int Option = 1;
            float[] Array = new float[1000];
            int NumberOfItems = 0;
            float ItemToSearch;


            do
            {

                Console.WriteLine("-----------------------------");
                Console.WriteLine("Menu (Please choose option: )");
                Console.WriteLine("Add new data - 1");
                Console.WriteLine("See all data entered - 2");
                Console.WriteLine("Find an item, to see whether it has been entered or not - 3");
                Console.WriteLine("View a summary of statistics: amount of data, sum, average, maximum, minimum - 4");
                Console.WriteLine("Exit the program - 5");

                Console.Write("Option: ");
                Option = Convert.ToInt32(Console.ReadLine());

                switch (Option)
                {
                    case 1:
                        Console.WriteLine("Add new data - 1");
                        Console.Write("Please enter the number: ");
                        Array[NumberOfItems] = Convert.ToSingle(Console.ReadLine());
                        NumberOfItems++;
                        break;

                    case 2:
                        Console.WriteLine("See all data entered - 2");
                        if (NumberOfItems != 0)
                        {
                            for (int i = 0; i < NumberOfItems; i++)
                            {
                                Console.WriteLine("Element {0}: {1}", i + 1, Array[i]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Array is empty!!!");
                        }

                        break;
                    case 3:
                        Console.WriteLine("Find an item, to see whether it has been entered or not - 3");

                        if (NumberOfItems != 0)
                        {
                            Console.Write("Please choose item to search: ");
                            ItemToSearch = Convert.ToSingle(Console.ReadLine());
                            string result = Array.Contains(ItemToSearch) ? "Item exist!!!" : "There are no such item in Array";
                            Console.WriteLine(result);
                        }
                        else
                        {
                            Console.WriteLine("Array is empty!!!");
                        }
                        break;
                    case 4:
                        Console.WriteLine("View a summary of statistics: amount of data, sum, average, maximum, minimum - 4");
                        if (NumberOfItems != 0)
                        {
                            Console.WriteLine("Statistics: ");
                            Console.WriteLine("Amount of data: {0}", NumberOfItems);
                            Console.WriteLine("Sum: {0}", Array.Take(NumberOfItems).Sum());
                            Console.WriteLine("Average: {0}", Array.Take(NumberOfItems).Average());
                            Console.WriteLine("Maximum: {0}", Array.Take(NumberOfItems).Max());
                            Console.WriteLine("Minimum: {0}", Array.Take(NumberOfItems).Min());
                        }
                        else
                        {
                            Console.WriteLine("Array is empty!!!");
                        }

                        break;
                    case 5:
                        Console.WriteLine("Exit the program - 5");
                        break;

                    default:
                        Console.WriteLine("Please choose number between 1 nad 5");
                        break;
                }

            } while (Option != 5);

        }
    }
}
