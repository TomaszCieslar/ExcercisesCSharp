using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.Linq
{
    class LINQQueries
    {
        static void Main(string[] args)
        {
            var movies = new List<Movie>
            {
                new Movie {Title = "a", Rating = 8.1f, Year=1983},
                new Movie {Title = "b", Rating = 8.2f, Year=1984},
                new Movie {Title = "c", Rating = 8.3f, Year=1985},
                new Movie {Title = "d", Rating = 8.4f, Year=1986}
            };

            //   var query = movies.Where(m=>m.Year>1985);

            var query = movies.Filter(m => m.Year > 1985);

            foreach (var item in query)
            {
                Console.WriteLine(item.Title);
            }
        }
    }

    public class Movie
    {
        public string Title { get; set; }
        public float Rating { get; set; }

        int _year;

        public int Year
        {
            get
            {
                Console.WriteLine($"returning {_year} for { Title}");
                return _year;
            }
            set
            {
                _year = value;
            }
        }
    }
    public static class MyLinq2
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source,
                                                Func<T, bool> predicate)
        {
            var result = new List<T>();

            foreach (var item in result)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }


            return result;
        }
    }
}
