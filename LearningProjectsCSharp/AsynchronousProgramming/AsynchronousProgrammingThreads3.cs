using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LearningProjectsCSharp.AsynchronousProgramming
{
    public class AsynchronousProgrammingThreads3
    {
        public void Main()
        {
            bool stopped = false;

            Thread t = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));
            t.Start();


            Console.WriteLine("Press any key to exit... ");
            Console.ReadLine();

            stopped = true;

            t.Join();

        }

        public static void ThreadMethod(object temp)
        {
            for (int i = 0; i < (int)temp; i++)
            {
                Console.WriteLine($"Thread {i}");
                Thread.Sleep(0);
            }

        }
    }
}
