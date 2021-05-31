using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.ArrayStructures
{
    class ArraysStructuresArrayOfStruct
    {
        struct point
        {
            public short x;
            public short y;
            public byte r;
            public byte g;
            public byte b;

        }

        void Main(string[] args)
        {
            //Expand the previous exercise(struct point), so that up to 1.000 points can be stored, 
            //using an "array of struct". Ask the user for data for the first two points and then display them.

            int NumberOfPoints = 2;
            point[] Array = new point[NumberOfPoints];

            for (int i = 0; i < NumberOfPoints; i++)
            {
                Console.WriteLine("Point creating process: ");

                point item = new point();


                Console.Write("x: ");
                item.x = Convert.ToInt16(Console.ReadLine());

                Console.Write("y: ");
                item.y = Convert.ToInt16(Console.ReadLine());

                Console.Write("r: ");
                item.r = Convert.ToByte(Console.ReadLine());

                Console.Write("g: ");
                item.g = Convert.ToByte(Console.ReadLine());

                Console.Write("b: ");
                item.b = Convert.ToByte(Console.ReadLine());
                Array[i] = item;

            }

            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("Point {0} : x - {1}, y - {2}, r - {3}, g - {4}, b - {5}", i + 1, Array[i].x, Array[i].y, Array[i].r, Array[i].g, Array[i].b);
            }
            Console.ReadLine();

        }
    }
}
