using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningProjectsCSharp.AsynchronousProgramming
{
    public class AsynchronousProgrammingPLINQ1
    {
        public void Main()
        {
            var numbers = Enumerable.Range(1, 10);
            var parallelResult = numbers.AsParallel()
                    .Where(i => i % 2 == 0)
                    .ToArray();

            foreach (var item in parallelResult)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
