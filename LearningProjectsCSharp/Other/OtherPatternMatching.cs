using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.Other
{
    class OtherPatternMatching
    {
        static void Main(string[] args)
        {
            object[] data = { null, 42, new Person("test name 1"), new Person("test name 2") };

            foreach (var item in data)
            {
                // IsPattern(item);
                SwitchPattern(item);

            }
        }

        private static void SwitchPattern(object item)
        {
            switch (item)
            {
                case null:
                    break;
                case int i:
                    break;
                case Person p when p.ToString().StartsWith("test"):
                    break;
                case var x:
                    break;
                default:
                    break;
            }
        }

        private static void IsPattern(object item)
        {
            if (item is null)
            {
                Console.WriteLine("const pattern");
            }

            if (item is 42)
            {
                Console.WriteLine("const pattern");
            }

            if (item is int i)
            {
                Console.WriteLine($"type patern with value {i}");
            }

            if (item is Person p)
            {
                Console.WriteLine($"type pattern with value {p.ToString()}");
            }

            if (item is var x)
            {
                Console.WriteLine($"var pattern with the type {x?.GetType()?.Name}");
            }

        }
    }
    internal class Person
    {
        private string v;

        public Person(string v)
        {
            this.v = v;
        }
    }
}
