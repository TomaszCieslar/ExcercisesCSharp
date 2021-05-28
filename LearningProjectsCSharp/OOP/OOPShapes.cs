using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.OOP
{
    class OOPShapes
    {
        void Main()
        {

        }
    }
    class Circle : Shape
    {
        protected double radius;
    }
    class Location
    {
        private double x, y;
    }
    class Rectangle : Shape
    {
        protected double side1, side2;
    }

    class Shape
    {
        protected Location c;

        public string ToString()
        {
            return "";
        }

        public double Area()
        {
            return 0.000;
        }

        public double Perimeter()
        {
            return 0.000;
        }
    }
}
