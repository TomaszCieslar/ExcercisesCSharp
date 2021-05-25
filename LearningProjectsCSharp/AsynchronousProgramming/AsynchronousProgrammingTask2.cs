using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningProjectsCSharp.AsynchronousProgramming
{
    public class AsynchronousProgrammingTask2
    {
        public void Main()
        {
            Task<int> t = Task.Run(() => {
                return 42;
            });

            Console.WriteLine(t.Result);

            Task<int> t2 = Task.Run(() => {
                return 42;
            }).ContinueWith((i) => {

                return t.Result * 2;
            });

            Console.WriteLine(t2.Result);


            Console.ReadLine();
        }
    }
}
