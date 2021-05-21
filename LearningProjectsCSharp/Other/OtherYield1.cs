using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.Other
{
    public class OtherYield1
    {
        static List<int> MyList = new List<int>();

        public void Main()
        {
            FillList();

            foreach (var item in FilterWithYied())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
        private static IEnumerable<int> FilterWithoutYied()
        {
            List<int> temp = new List<int>();
            foreach (var item in MyList)
            {
                if (item > 3)
                {
                    temp.Add(item);
                }
            }
            return temp;

        }

        private static IEnumerable<int> FilterWithYied()
        {

            foreach (var item in MyList)
            {
                if (item > 3)
                {
                    yield return item;
                }
            }


        }

        private static void FillList()
        {
            MyList.Add(1);
            MyList.Add(2);
            MyList.Add(3);
            MyList.Add(4);
            MyList.Add(5);
            MyList.Add(1);
        }
    }
}
