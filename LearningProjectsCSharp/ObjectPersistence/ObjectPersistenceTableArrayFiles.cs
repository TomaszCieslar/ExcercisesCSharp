using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LearningProjectsCSharp.ObjectPersistence
{
    public class ObjectPersistenceTableArrayFiles
    {
        public void Main()
        {
            //   Expand the exercise, so that it contains two new methods, 
            //   to dump the data of the array into a binary file and restore 
            //the data from the file.

            Table[] tableList = new Table[10];
            Random random = new Random();

            for (int i = 0; i < tableList.Length - 1; i++)
            {
                tableList[i] = new Table(
                    random.Next(50, 201),
                    random.Next(50, 201));
            }

            tableList[0].Save("1.dat");
            tableList[9] = new Table(0, 0);
            tableList[9].Load("1.dat");


            for (int i = 0; i < tableList.Length; i++)
            {
                tableList[i].ShowData();
            }

            Console.ReadLine();
        }
    }

    class Table
    {
        protected int width, height;

        public Table(int tableWidth, int tableHeight)
        {
            width = tableWidth;
            height = tableHeight;
        }

        public void ShowData()
        {
            Console.WriteLine("Width: {0}, Height: {1}", width, height);
        }

        public void Save(string fileName)
        {
            BinaryWriter myFile = new BinaryWriter(File.Open(fileName, FileMode.Create));

            myFile.Write(width);
            myFile.Write(height);
            myFile.Close();
        }

        public void Load(string fileName)
        {
            BinaryReader inputFile = new BinaryReader(File.Open(fileName, FileMode.Open));
            height = inputFile.ReadInt32();
            width = inputFile.ReadInt32();
            inputFile.Close();
        }


    }
}
