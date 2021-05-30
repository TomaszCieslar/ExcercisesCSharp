using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningProjectsCSharp.Functions
{
    class FunctionsFunctionReturningAValue2
    {
        public void Main()
        {
            Console.WriteLine("\"Hello, how are you\" contains {0} spaces", CountSpaces("Hello, how are you"));
        }
        private static int CountSpaces(string v)
        {
            return v.Count(s => s == ' ');
        }

    }
}
