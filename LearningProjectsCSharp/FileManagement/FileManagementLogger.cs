using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LearningProjectsCSharp.FileManagement
{
    public class FileManagementLogger
    {
        public void Main()
        {
            Logger.Write("myLog.txt", "This text is being logged");
        }
    }

    internal static class Logger
    {
        public static void Write(string fileName, string log)
        {
            StreamWriter myStream = File.AppendText(fileName);
            myStream.WriteLine(DateTime.Now + " - " + log);
            myStream.Close();

        }
    }
}
