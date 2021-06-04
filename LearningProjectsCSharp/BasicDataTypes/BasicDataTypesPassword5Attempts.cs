using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.BasicDataTypes
{
    class BasicDataTypesPassword5Attempts
    {
        static void Main(string[] args)
        {

            //Write a program which asks the user for his login and password.Both must be strings.
            //After 5 wrong attempts, the user will be rejected.

            string Login;
            string Password;
            int NumberOfTests;
            const int MaximumNumberOfTests = 5;

            NumberOfTests = 0;

            do
            {
                NumberOfTests++;

                Console.Write("Login: ");
                Login = Console.ReadLine();


                Console.Write("Password: ");
                Password = Console.ReadLine();




            } while ((Login != "Login" && Password != "Password") && NumberOfTests != MaximumNumberOfTests);




        }
    }
}
