using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.Functions
{
    class FunctionsWriteCentered
    {
        public void Main()
        {
            WriteCentered("Hello!");
            Console.ReadLine();
        }
        private static void WriteCentered(string text)
        {
            int i = 0;

            for (; i < 17; i++)
                Console.WriteLine();

            for (i = 0; i < 36; i++)
                Console.Write(" ");

            Console.Write(text);

            for (i = 0; i < 14; i++)
                Console.WriteLine();
        }
    }
}
