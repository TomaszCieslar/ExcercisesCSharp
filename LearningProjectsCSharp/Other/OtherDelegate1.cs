using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LearningProjectsCSharp.Other
{
    public class OtherDelegate1
    {
        static FileStream fs;
        static StreamWriter sw;

        public delegate void PrintMessage(string s);

        public void Main()
        {
            PrintMessage pm1 = new PrintMessage(WriteToConsole);
            PrintMessage pm2 = new PrintMessage(WriteToFile);
            SendString(pm1);
            SendString(pm2);

            Console.ReadLine();
        }

        public static void WriteToConsole(string s)
        {
            Console.WriteLine("Wiadomosc {0}", s);
        }

        public static void WriteToFile(string s)
        {
            fs = new FileStream("c:\\wiaodmosc.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);

            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public static void SendString(PrintMessage pm)
        {
            pm("Witaj Świecie");
        }
    }
}
