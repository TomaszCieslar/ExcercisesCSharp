using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningProjectsCSharp.Linq
{
    class LINQExperiments
    {
        static void Main(string[] args)
        {
            Func<int, int> squere = x => x * x;
            Func<int, int, int> add = (x, y) => x + y;

            Action<int> write = x => Console.WriteLine(x);
            write(squere(3));

            IEnumerable<Emploee> developers = new Emploee[]
            {
                new Emploee {id = 1, Name = "Scott" },
                new Emploee {id = 2, Name = "Chris" }
            };

            IEnumerable<Emploee> sales = new List<Emploee>()
            {
                new Emploee {id = 3, Name = "Alex" }
            };

            //Console.WriteLine(sales.Count());
            //IEnumerator<Emploee> enumerator = developers.GetEnumerator();

            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current.Name);
            //}

            foreach (var emploee in developers.Where(
                    e => e.Name.StartsWith("S")
                ))
            {
                Console.WriteLine(emploee.Name);
            }



            Console.ReadLine();

        }
    }

    public static class MyLinq
    {
        public static int Count<T>(this IEnumerable<T> sequence)
        {
            int count = 0;
            foreach (var item in sequence)
            {
                count += 1;
            }
            return count;
        }
    }

    public class Emploee
    {
        public int id { get; set; }
        public string Name { get; set; }
    }
}
