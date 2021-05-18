using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.BasicDataTypes
{
    public class BasicDataTypesTriangle
    {
        public void Main()
        {
            /*
            * Write a program which asks for a symbol and a width, and displays a triangle of that width, using that number for the inner symbol, as in this example: 
               Enter a symbol: 4 
               Enter the desired width: 5 
               44444 
               4444 
               444 
               44 
               4
            */

            int liczbaPowtorzen;
            char znak;

            Console.Write("Podaj liczbe powtórzen: ");
            liczbaPowtorzen = Convert.ToInt16(Console.ReadLine());

            Console.Write("Podaj znak: ");
            znak = Convert.ToChar(Console.ReadLine());

            for (int i = liczbaPowtorzen; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(znak);
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
