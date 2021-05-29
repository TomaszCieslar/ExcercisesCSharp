using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.MoreOnClasses
{
    class MoreOnClassesTableCoffetableArray
    {
        public void Main()
        {
            Table[] myTables = new Table[5];
            CoffeeTable[] myCoffeeTable = new CoffeeTable[5];



            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                myTables[i] = new Table(rnd.Next(50, 201), rnd.Next(50, 201));
                myTables[i].ShowData();

                myCoffeeTable[i] = new CoffeeTable(rnd.Next(40, 121), rnd.Next(40, 121));
                myCoffeeTable[i].ShowData();
            }


            Console.ReadLine();
        }
    }
    internal class Table
    {
        protected float width, height;

        public Table()
        {
        }
        public Table(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public float Width
        {
            set { width = value; }
            get { return width; }
        }
        public float Height
        {
            set { height = value; }
            get { return height; }
        }

        virtual public void ShowData()
        {
            Console.WriteLine("Width: {0}, Heigth: {1}", width, height);
        }
    }
    internal class CoffeeTable : Table
    {
        public CoffeeTable(float width, float height)
        {

            this.width = width;
            this.height = height;
        }

        public override void ShowData()
        {
            Console.WriteLine("(Coffee table) Width: {0}, Heigth: {1}", width, height);
        }
    }
}
