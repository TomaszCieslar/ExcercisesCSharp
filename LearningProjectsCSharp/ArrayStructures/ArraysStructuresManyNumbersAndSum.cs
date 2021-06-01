using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.ArrayStructures
{
    class ArraysStructuresManyNumbersAndSum
    {
        void Main(string[] args)
        {
            //Create a program which asks the user for several numbers (until he enters "end" 
            //and displays their sum). When the execution is going to end, it must display all the numbers entered, and the sum again, as follows: 

            //Enter a number: 5
            //Sum = 5
            //Enter a number: 3
            //Sum = 8
            //Enter a number: end
            //The numbers are: 5 3
            //The sum is: 8

            List<int> Array = new List<int>();

            string answer = "";
            int sum = 0;
            bool result;
            int number, counter;
            counter = 0;

            while (answer != "end")
            {

                Console.Write("Enter a number: ");
                answer = Console.ReadLine();

                result = int.TryParse(answer, out number);

                if (result)
                {
                    sum += number;
                    Array.Add(number);
                    counter++;
                }

                if (answer != "end")
                {
                    Console.WriteLine("Sum = {0}", sum);
                }
                else
                {
                    Console.WriteLine("The numbers are: {0}", String.Join(" ", Array));
                    Console.WriteLine("The sum is {0}", sum);
                }

            }


            Console.ReadLine();
        }
    }
}
