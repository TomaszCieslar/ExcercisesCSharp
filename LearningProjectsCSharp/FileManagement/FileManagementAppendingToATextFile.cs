using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LearningProjectsCSharp.FileManagement
{
    public class FileManagementAppendingToATextFile
    {
        public void Main()
        {

            string sentences = "";
            StreamWriter myFile;

            myFile = File.AppendText("test.txt");

            Console.WriteLine("Please add several sentences: ");

            do
            {
                sentences = Console.ReadLine();

                if (!string.IsNullOrEmpty(sentences))
                {
                    myFile.WriteLine(sentences);
                }

            } while (!string.IsNullOrEmpty(sentences));
            myFile.Close();

        }
    }
}
