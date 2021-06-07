using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.BasicDataTypes
{
    class BasicDataTypesCalculatorDouble
    {
        static void Main(string[] args)
        {
            /*
             Calculate the perimeter, area and diagonal of a rectangle, given its width and its height. 
            (Hint: use y = Math.Sqrt(x) to calculate a square root)
             */

            int Width;
            int Height;
            double Perimetr, Area, Diagonal;

            Console.Write("Width: ");
            Width = Convert.ToInt16(Console.ReadLine());

            Console.Write("Height: ");
            Height = Convert.ToInt16(Console.ReadLine());

            Perimetr = (2 * Width) + (2 * Height);
            Area = Width * Height;
            Diagonal = Math.Sqrt(Width ^ 2 + Height ^ 2);

            Console.WriteLine("Perimetr: {0}", Perimetr);
            Console.WriteLine("Area: {0}", Area);
            Console.WriteLine("Diagonal: {0}", Diagonal);

            Console.ReadLine();
        }
    }
}
