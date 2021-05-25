using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningProjectsCSharp.AsynchronousProgramming
{
    public class AsynchronousProgrammingTask3
    {
        public void Main()
        {
            Task<int> t = Task.Run(() => {
                return 42;
            });

            t.ContinueWith((i) => {
                Console.WriteLine("Canceled");
            }, TaskContinuationOptions.OnlyOnCanceled);

            t.ContinueWith((i) =>
            {
                Console.WriteLine("Faulted");
            }, TaskContinuationOptions.OnlyOnFaulted);

            var completedTask = t.ContinueWith((i) => {
                Console.WriteLine("Completed");

            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();
            Console.ReadLine();
        }
    }
}
