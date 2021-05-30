using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.Functions
{
    class FunctionsFunctionWithParameters
    {
        public void Main()
        {
            SayHello("John");
            SayGoodbay();
            Console.ReadLine();
        }

        public static void SayHello(string name)
        {
            Console.WriteLine("SayHello: {0}", name);
        }

        public static void SayGoodbay()
        {
            Console.WriteLine("SayGoodbay");
        }

    }
}
