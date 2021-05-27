using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.MoreOnClasses
{
    public class MoreOnClassesComplexNumbers
    {
        public void Main()
        {
            ComplexNumber number = new ComplexNumber(5, 2);
            Console.WriteLine("Number is: " + number.ToString());

            number.SetImg(-3);
            Console.WriteLine("Number is: " + number.ToString());

            Console.Write("Magnitude is: ");
            Console.WriteLine(number.GetMagnitude());

            ComplexNumber number2 = new ComplexNumber(-1, 1);
            number.Add(number2);
            Console.Write("After adding: ");
            Console.WriteLine(number.ToString());

            Console.ReadLine();
        }
    }

    internal class ComplexNumber
    {
        protected double RealPart;
        protected double ImgPart;


        public ComplexNumber(double realPart, double imgPart)
        {
            this.RealPart = realPart;
            this.ImgPart = imgPart;
        }

        public double GetReal()
        {
            return RealPart;
        }

        public void SetReal(double RealPart)
        {
            this.RealPart = RealPart;
        }

        public double GetImg()
        {
            return ImgPart;
        }

        public void SetImg(double ImgPart)
        {
            this.ImgPart = ImgPart;
        }

        public override string ToString()
        {
            return "(" + RealPart + "," + ImgPart + ")";
        }

        public double GetMagnitude()
        {
            return Math.Sqrt((RealPart * RealPart) + (ImgPart * ImgPart));
        }


        public void Add(ComplexNumber c2)
        {
            RealPart += c2.GetReal();
            ImgPart += c2.GetImg();
        }

    }
}
