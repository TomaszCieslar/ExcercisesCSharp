using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.BasicDataTypes
{
    class BasicDataTypesCalculator_if_
    {
        public void Main()
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int result = 0;
            char operation;

            Console.Write("Enter first number: ");
            firstNumber = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter operation: ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second number: ");
            secondNumber = Convert.ToInt16(Console.ReadLine());

            if (operation == '+')
            {
                result = firstNumber + secondNumber;
            }

            if (operation == '-')
            {
                result = firstNumber - secondNumber;
            }

            if (operation == '*')
            {
                result = firstNumber * secondNumber;
            }

            if (operation == '/')
            {
                result = firstNumber / secondNumber;
            }


            Console.WriteLine("{0} {1} {2} = {3}", firstNumber, operation, secondNumber, result);

            Console.ReadLine();
        }
    }
}
