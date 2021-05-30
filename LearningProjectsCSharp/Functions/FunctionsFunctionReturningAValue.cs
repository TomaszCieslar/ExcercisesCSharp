using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.Functions
{
    class FunctionsFunctionReturningAValue
    {
        public void Main()
        {
            //            Create a program whose Main must be like this: 

            //public static void Main()
            //        {
            //            int x = 3;
            //            int y = 5;
            //            Console.WriteLine(Sum(x, y));
            //        }

            int x = 3;
            int y = 5;
            Console.WriteLine(Sum(x, y));
            Console.ReadLine();
        }

        public static int Sum(int x, int y)
        {
            return x + y;
        }
    }
    
}
