using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningProjectsCSharp.Functions
{
    public class FunctionsSumOfArray
    {
        public void Main()
        {
            int[] example = { 20, 10, 5, 2 };
            Console.WriteLine("The sum of the example array is {0}", Sum(example));
            Console.ReadLine();

        }


        public static int Sum(int[] Array)
        {
            return Array.Sum();
        }
    }
}
