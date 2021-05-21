using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LearningProjectsCSharp.AsynchronousProgramming
{
    public class AsynchronousProgrammingThreads2
    {
        public void Main()
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(20);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main scope");
                Thread.Sleep(0);
            }

            t.Join();

            Console.ReadLine();
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
