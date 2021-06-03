using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.BasicDataTypes
{
    class BasicDataTypesSphereFloat
    {
        void Main(string[] args)
        {

            //Calculate the surface and volume of a sphere, given its radius
            //(surface = 4 * pi * radius squared; volume = 4 / 3 * pi * radius cubed). 


            float Promien;

            Console.WriteLine("Podaj promień kuli: ");
            Promien = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Powierzchnia: {0}", 4 * Math.PI * Math.Pow(Promien, 2));
            Console.WriteLine("Objetosc: {0}", 4 / 3 * Math.PI * Math.Pow(Promien, 3));

            Console.ReadLine();



        }
    }
}
