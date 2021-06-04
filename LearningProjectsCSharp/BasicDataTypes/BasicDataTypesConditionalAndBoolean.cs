using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.BasicDataTypes
{
    class BasicDataTypesConditionalAndBoolean
    {
        static void Main(string[] args)
        {
            /*
            Create a program that uses the conditional operator to give a boolean variable named "bothEven" 
            the value "true" if two numbers entered by the user are the even, or "false" if any of them is odd.
            */

            int LiczbaPierwsza;
            int LiczbaDruga;

            bool bothEven;

            Console.Write("Podaj pierwsza liczbe: ");
            LiczbaPierwsza = int.Parse(Console.ReadLine());

            Console.Write("Podaj pierwsza liczbe: ");
            LiczbaDruga = int.Parse(Console.ReadLine());

            if ((LiczbaPierwsza % 2 == 0) && (LiczbaDruga % 2 == 0))
            {
                bothEven = true;
            }

            else
            {
                bothEven = false;
            }


            Console.WriteLine("Wynik: {0}", bothEven);
            Console.ReadLine();



        }
    }
}
