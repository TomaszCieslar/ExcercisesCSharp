using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.Functions
{
    class FunctionsWriteUnderlined
    {
        public void Main()
        {
            WriteUnderlined("Hello!");
            Console.ReadLine();
        }

        private static void WriteUnderlined(string text)
        {
            int countSpaces = (80 - text.Length) / 2;
            int i = 0;

            for (; i < countSpaces; i++)
                Console.Write(" ");

            Console.WriteLine(text);

            for (i = 0; i < countSpaces; i++)
                Console.Write(" ");

            for (i = 0; i < text.Length; i++)
                Console.Write("_");
        }
    }
}
