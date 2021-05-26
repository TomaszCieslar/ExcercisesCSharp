using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LearningProjectsCSharp.ObjectPersistence
{
    public class ObjectPersistenceTableSetOfTablesFiles
    {
        public void Main()
        {
            // Expand the exercise(tables + array + files), so that it contains three classes: Table, 
            //SetOfTables and a test program.SetOfTables must contain the array of tables, and two methods, 
            //to dump(all) the data of the array into a binary file and restore the data from the file.

            SetOfTables s = new SetOfTables(5);
            s.CreateAtRandom();
            s.ShowData();

            s.Save("tables.dat");
            s.CreateAtRandom();
            s.ShowData();

            s.Load("tables.dat");
            s.ShowData();

            Console.ReadLine();
        }
    }
    class SetOfTables
    {
        private int size;
        private ArrayList data;
        Random random;

        public SetOfTables(int newSize)
        {
            size = newSize;
            data = new ArrayList();
            random = new Random();
        }

        public SetOfTables() : this(10) { }

        public void CreateAtRandom()
        {
            data = new ArrayList();
            for (int i = 0; i < size; i++)
            {
                data.Add(new Table(random.Next(50, 201), random.Next(50, 201)));
            }
        }

        public void ShowData()
        {
            foreach (Table item in data)
            {
                item.ShowData();
            }
            Console.WriteLine();
        }

        public void Save(string outputFile)
        {
            BinaryWriter myFile = new BinaryWriter(File.Open(outputFile, FileMode.Create));

            myFile.Write((int)size);

            foreach (Table item in data)
            {
              //  myFile.Write(item.GetHeight());
              //  myFile.Write(item.GetWidth());
            }

            myFile.Close();
        }

        public void Load(string inputFile)
        {
            BinaryReader myFile = new BinaryReader(File.Open(inputFile, FileMode.Open));

            int size = myFile.ReadInt32();
            data = new ArrayList();

            for (int i = 0; i < size; i++)
            {
                int height = myFile.ReadInt32();
                int width = myFile.ReadInt32();
                data.Add(new Table(width, height));
            }
            myFile.Close();
        }
    }

}
