using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningProjectsCSharp.AsynchronousProgramming
{
    class AsynchronousProgrammingTask1
    {
        static void Main(string[] args)
        {
            Task t = Task.Run(() => {

                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("*");
                }

            });

            t.Wait();
        }
    }
}
