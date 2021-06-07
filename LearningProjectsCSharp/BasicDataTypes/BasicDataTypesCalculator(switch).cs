using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.BasicDataTypes
{
    class BasicDataTypesCalculator_switch_
    {
        static void Main(string[] args)
        {
            /*
            Write a program which asks the user for two numbers and an operation to perform on them(+, -, *, x,/) and displays the result of that operation, as in this example: 
             Enter first number: 5
             Enter operation: +
             Enter second number: 7
             5 + 7 = 12
 
             Note: you MUST use "switch", not "if"
            */

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

            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    result = firstNumber / secondNumber;
                    break;
                default:
                    break;
            }



            Console.WriteLine("{0} {1} {2} = {3}", firstNumber, operation, secondNumber, result);

            Console.ReadLine();
        }
    }
}
