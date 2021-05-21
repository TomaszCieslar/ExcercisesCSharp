using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LearningProjectsCSharp.AsynchronousProgramming
{
    public class AsynchronousProgrammingThreads5
    {
        private static ThreadLocal<int> _field =
            new ThreadLocal<int>(() => {

                return Thread.CurrentThread.ManagedThreadId;
            });

        public void Main()
        {
            new Thread(() => {

                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Thread A {0}", i);
                }

            }).Start();

            new Thread(() =>
            {

                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Thread B {0}", i);
                }

            }).Start();

            Console.ReadLine();
        }
    }
}
