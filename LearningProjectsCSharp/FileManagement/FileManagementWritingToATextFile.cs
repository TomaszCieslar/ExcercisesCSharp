using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LearningProjectsCSharp.FileManagement
{
    public class FileManagementWritingToATextFile
    {
        public void Main()
        {
            string sentence = "";
            StreamWriter myFile;
            myFile = File.CreateText("test.txt");

            do
            {
                Console.WriteLine("Write a sentence: ");
                sentence = Console.ReadLine();

                if (sentence.Length != 0)
                {
                    myFile.WriteLine(sentence);
                }
            } while (sentence.Length != 0);
            myFile.Close();

        }
    }
}
