using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.MoreOnClasses
{
    class MoreOnClassesArrayOfObjects
    {
        public void Main()
        {
            TableDefinition[] ArrayOfTables = new TableDefinition[10];

            for (int i = 0; i < ArrayOfTables.Length; i++)
            {
                Random rnd = new Random();
                ArrayOfTables[i] = new TableDefinition(rnd.Next(50, 201), rnd.Next(50, 201));
                ArrayOfTables[i].ShowData();
            }

            Console.ReadLine();

        }
    }

    internal class TableDefinition
    {
        readonly private float width;
        readonly private float height;

        public TableDefinition(float w, float h)
        {
            this.width = w;
            this.height = h;
        }


        public void ShowData()
        {
            System.Console.WriteLine("Width: {0}, Height {1}", width, height);
        }
    }
}
