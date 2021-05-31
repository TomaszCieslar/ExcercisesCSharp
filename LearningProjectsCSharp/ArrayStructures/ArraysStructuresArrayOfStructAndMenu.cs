using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningProjectsCSharp.ArrayStructures
{
    class ArraysStructuresArrayOfStructAndMenu
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
            //Expand the previous exercise(array of points), so that it displays a menu, in which the user can choose to: 

            //-Add data for one point
            //-Display all the entered points
            //- Calculate(and display) the average values for x and y
            //- Exit the program

            int Option = 4;

            List<point> ListOfPoints = new List<point>();

            do
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1 - Add data for one point");
                Console.WriteLine("2 - Display all the entered points");
                Console.WriteLine("3 - Calculate(and display) the average values for x and y");
                Console.WriteLine("4 - Exit the program");

                Console.Write("Please Choose option: ");
                Option = Convert.ToInt32(Console.ReadLine());
                Console.Write("---------------------");
                switch (Option)
                {
                    case 1:
                        Console.WriteLine("1 - Add data for one point");
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
                        ListOfPoints.Add(item);

                        break;
                    case 2:
                        Console.WriteLine("2 - Display all the entered points");
                        int i = 1;
                        foreach (var point in ListOfPoints)
                        {
                            Console.WriteLine("Point {0} : x - {1}, y - {2}, r - {3}, g - {4}, b - {5}", i, point.x, point.y, point.r, point.g, point.b);
                            i++;
                        }
                        break;
                    case 3:
                        Console.WriteLine("3 - Calculate(and display) the average values for x and y");
                        Console.WriteLine("Avare x: {0}", ListOfPoints.Average(point => point.x));
                        Console.WriteLine("Avare y: {0}", ListOfPoints.Average(point => point.y));

                        break;
                    case 4:
                        Console.WriteLine("4 - Exit the program");
                        break;

                    default:
                        Console.WriteLine("Please choose option between 1 and 4");
                        break;
                }
            } while (Option != 4);


        }
    }
}
