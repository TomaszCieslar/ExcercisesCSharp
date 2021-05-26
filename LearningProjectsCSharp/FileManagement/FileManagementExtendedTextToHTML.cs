using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LearningProjectsCSharp.FileManagement
{
    public class FileManagementExtendedTextToHTML
    {
        public void Main()
        {
            TextToHTML textToHTML = new TextToHTML();
            textToHTML.Add("Hello");
            textToHTML.Add("How are you?");

            textToHTML.Display();
            textToHTML.ToFile("test.html");

            Console.ReadLine();
        }
    }

    public class TextToHTML
    {
        public string[] html;
        private int lines;
        private int count;

        public TextToHTML()
        {
            count = 0;
            lines = 1000;

            html = new string[lines];
        }

        public void ToFile(string nameFile)
        {
            try
            {
                StreamWriter file = File.CreateText(nameFile);
                file.WriteLine(ToString());
                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!!!");
            }
        }

        public void Add(string line)
        {
            if (count < lines)
            {
                html[count] = line;
                count++;
            }
        }

        public string ToString()
        {
            string textHTML;
            textHTML = "\n";
            textHTML += "\n";

            for (int i = 0; i < count; i++)
            {
                textHTML += "";
                textHTML += html[i];
                textHTML += "";
            }

            textHTML = "\n";
            textHTML += "\n";

            return textHTML;
        }

        public void Display()
        {
            Console.WriteLine(ToString());
        }

    }
}
