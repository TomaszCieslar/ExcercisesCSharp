using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.ArrayStructures
{
    class ArraysStructuresStruct
    {
        struct point
        {
            public short x;
            public short y;
            public byte r;
            public byte g;
            public byte b;

        }

        static void Main(string[] args)
        {

            //Create a "struct" to store data of 2D points.The fields for each point will be: 

            //x coordinate(short)
            //y coordinate(short)
            //r(red colour, byte)
            //g(green colour, byte)
            //b(blue colour, byte)

            //Write a program which creates two "points", asks the user for their data, and then displays their content.

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
