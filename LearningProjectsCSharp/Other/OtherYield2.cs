using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.Other
{
    public class OtherYield2
    {
        static List<int> MyList = new List<int>();

        public void Main()
        {
            FillList();
            foreach (var item in MyListWithYield())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        private static IEnumerable<int> MyListWithYield()
        {
            int runningTotal = 0;
            foreach (var item in MyList)
            {
                runningTotal += item;
                yield return runningTotal;
            }


        }

        private static void FillList()
        {

            MyList.Add(1);
            MyList.Add(2);
            MyList.Add(3);
            MyList.Add(4);
            MyList.Add(5);
            MyList.Add(6);
            MyList.Add(7);
        }
    }
}
