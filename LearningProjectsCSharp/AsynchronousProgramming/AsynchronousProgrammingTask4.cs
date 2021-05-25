using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningProjectsCSharp.AsynchronousProgramming
{
    public class AsynchronousProgrammingTask4
    {
        public void Main()
        {
            Task<Int32[]> parent = Task.Run(() => {

                var result = new Int32[3];

                new Task(() => result[0] = 0, TaskCreationOptions.AttachedToParent).Start();
                new Task(() => result[1] = 1, TaskCreationOptions.AttachedToParent).Start();
                new Task(() => result[2] = 2, TaskCreationOptions.AttachedToParent).Start();

                return result;

            });

            var finalTask = parent.ContinueWith(
                parentTask => {
                    foreach (var i in parentTask.Result)
                    {
                        Console.WriteLine(i);
                    }
                });

            Console.ReadLine();
        }
    }
}
