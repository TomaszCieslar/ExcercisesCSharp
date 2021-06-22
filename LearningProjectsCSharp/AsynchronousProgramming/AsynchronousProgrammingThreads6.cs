using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LearningProjectsCSharp.AsynchronousProgramming
{
    class AsynchronousProgrammingThreads6
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem((s) => {

                Console.WriteLine("Working on thread from threadpool");

            });

            Console.ReadLine();
        }
    }
}
