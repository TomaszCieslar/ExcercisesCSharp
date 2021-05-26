using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LearningProjectsCSharp.FileManagement
{
    public class FileManagementDisplayFileContents
    {
        public void Main()
        {
            //Create a program to display all the contents of a text file on screen(note: you must use a StreamReader). 
            //The name of the file will be entered in the command line or(if there is no command line present) asked to the user by the program.

            string fileName = "";

            Console.WriteLine("Please enter file name: ");
            fileName = Console.ReadLine();

            StreamReader myFile;
            try
            {
                myFile = File.OpenText(fileName);
                string line = "";
                do
                {
                    line = myFile.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                        Console.WriteLine(line);

                } while (!string.IsNullOrEmpty(line));
            }

            catch (Exception e)
            {
                Console.WriteLine("Error in oppening file");
            }


        }
    }
}
