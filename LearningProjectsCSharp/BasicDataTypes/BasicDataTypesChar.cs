using System;

namespace LearningProjectsCSharp.BasicDataTypes
{
    public class BasicDataTypesChar
    {
        public void Main()
        {
            char pierwszaLitera;
            char drugaLitera;
            char trzeciaLitera;

            Console.Write("Podaj pierwszą literę: ");
            pierwszaLitera = Convert.ToChar(Console.ReadLine());

            Console.Write("Podaj drugą literę: ");
            drugaLitera = Convert.ToChar(Console.ReadLine());

            Console.Write("Podaj trzecią literę: ");
            trzeciaLitera = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("litery w odróconej kolejnosci to: {0} {1} {2}", trzeciaLitera, drugaLitera, pierwszaLitera);

            Console.ReadLine();
        }
    }
}
