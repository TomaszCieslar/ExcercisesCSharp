using System;
using System.Threading;

namespace LearningProjectsCSharp.AsynchronousProgramming
{
    public class AsynchronousProgramming_Threads
    {
        public void Main()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread");
                Thread.Sleep(0);
            }

            t.Join();

            Console.ReadLine();
        }

        public void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Thread proc: {i}");
                Thread.Sleep(0);
            }
        }
    }

}
