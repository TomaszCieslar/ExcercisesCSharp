using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LearningProjectsCSharp.AdditionalLibraries
{
    public class AdditionalLibrariesDisplayExecutableFilesIn
    {
        public void Main()
        {
            //Create a program to display the name(but not the path) of the executable 
            //files(.com, .exe, .bat, .cmd) in the current directory      

            string[] files = Directory.GetFiles(".");

            foreach (var item in files)
            {

                string extension = Path.GetExtension(item);
                switch (extension)
                {
                    case ".com":
                    case ".exe":
                    case ".bat":
                    case ".cmd":
                        Console.WriteLine(item.ToString());
                        break;
                    default:
                        break;
                }


            }

        }
    }
}
