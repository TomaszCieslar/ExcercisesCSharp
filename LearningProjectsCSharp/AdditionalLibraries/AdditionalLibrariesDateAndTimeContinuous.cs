using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LearningProjectsCSharp.AdditionalLibraries
{
    public class AdditionalLibrariesDateAndTimeContinuous
    {
        public void Main()
        {
            string time = DateTime.Now.ToLongTimeString();

            Console.SetCursorPosition(72, 1);
            Console.Write(time);
            Thread.Sleep(1000);

            Console.ReadLine();
        }
    }
}
