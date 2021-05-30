using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.Functions
{
    class FunctionsGreetingFarewell
    {
        public void Main()
        {

            SayHello();
            SayGoodbay();
            Console.ReadLine();
        }

        public static void SayHello()
        {
            Console.WriteLine("SayHello");
        }

        public static void SayGoodbay()
        {
            Console.WriteLine("SayGoodbay");
        }
    }
}
