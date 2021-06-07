using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LearningProjectsCSharp.Linq
{
    class LINQFundamentals
    {
        static void Main(string[] args)
        {
            string path = @"c:\windows";
            ShowLargeFileWithoutLinq(path);
            Console.WriteLine("****");
            ShowLargeFileWithLinq(path);

            Console.ReadLine();

        }

        private static void ShowLargeFileWithLinq(string path)
        {
            var query = new DirectoryInfo(path).GetFiles()
                         .OrderByDescending(f => f.Length)
                         .Take(5);

            foreach (var file in query)
            {
                Console.WriteLine($"{file.Name,-100} {file.Length,10:N0} ");
            }

        }

        private static void ShowLargeFileWithoutLinq(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] fileInfo = directory.GetFiles();
            Array.Sort(fileInfo, new FileInfoComparer());
            //foreach (FileInfo file in fileInfo)
            //{
            //    Console.WriteLine($"{file.Name, -100} {file.Length, 10:N0} ");
            //}

            // TOP 5
            for (int i = 0; i < 5; i++)
            {
                FileInfo file = fileInfo[i];
                Console.WriteLine($"{file.Name,-100} {file.Length,10:N0} ");
            }

        }
    }

    internal class FileInfoComparer : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            return y.Length.CompareTo(x.Length);
        }
    }
}
