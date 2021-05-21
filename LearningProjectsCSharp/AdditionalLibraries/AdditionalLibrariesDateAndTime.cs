using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.AdditionalLibraries
{
    public class AdditionalLibrariesDateAndTime
    {
        public void Main()
        {
            // Create a program to display the current date and time with the following format: 

            //Today is 6 of February of 2015.It´s 03:23:12

            string day = DateTime.Now.Day.ToString("00");
            string month = GetMonth(DateTime.Now.Month);
            string year = DateTime.Now.Year.ToString();
            string time = DateTime.Now.ToLongTimeString();


            Console.WriteLine($"Today is {day} of {month} of {year}.It´s {time}");
            Console.ReadLine();
        }

        static string GetMonth(int month)
        {
            string[] months =
             new string[] { "January", "February", "March", "April", "May", "June", "July",
                           "August", "September", "October", "November", "Decenber" };

            return months[month - 1];

        }

    }
}
