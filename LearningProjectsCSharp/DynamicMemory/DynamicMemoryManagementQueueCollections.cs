using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.DynamicMemory
{
    public class DynamicMemoryManagementQueueCollections
    {
        public void Main()
        {
            //Create a queue of strings, using the class Queue which already exists in the DotNet Platform.

            //Once created, show all the items stored in the queue.

            Queue<string> MyQueue = new Queue<string>();

            MyQueue.Enqueue("ItemOne");
            MyQueue.Enqueue("ItemTwo");
            MyQueue.Enqueue("ItemThree");

            foreach (var item in MyQueue)
            {
                Console.WriteLine(item.ToString());
            }


            Console.ReadLine();

        }
    }
}
