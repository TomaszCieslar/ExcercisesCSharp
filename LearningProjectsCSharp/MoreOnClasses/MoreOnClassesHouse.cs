using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.MoreOnClasses
{
    class MoreOnClassesHouse
    {
        public void Main()
        {
            bool debug = true;

            SmallApartment mySmallApartament = new SmallApartment();
            Person myPerson = new Person 
            {
                Name = "Juan",
                House = mySmallApartament    
            };

            myPerson.ShowData();




            if (debug)
                Console.ReadLine();
        }
    }
    internal class Door
    {
        protected string color;
        public string Color { get; set; }

        public Door()
        {
            color = "Brown";
        }

        public Door(string c)
        {
            this.color = c;
        }

        public void ShowData()
        {
            Console.WriteLine("I am a door, my color is {0} m2", this.color);
        }
    }
    internal class House
    {
        protected int area;
        protected Door door;

        public House(int area)
        {
            this.area = area;
            door = new Door();
        }

        public int Area
        {
            get { return area; }
            set { area = value; }
        }

        public Door Door
        {
            get { return door; }
            set { door = value; }
        }


        public virtual void ShowData()
        {
            Console.WriteLine("I am a house, my area is {0} m2", this.area);
        }
    }
    internal class Person
    {
        protected string name;
        protected House house;

        public Person()
        {
            name = "John";
            house = new House(50);
        }

        public Person(string name, House house)
        {
            this.name = name;
            this.house = house;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public House House
        {
            get { return house; }
            set { house = value; }
        }

        public void ShowData()
        {
            Console.WriteLine("My name is {0}.", name);
            house.ShowData();
            house.Door.ShowData();
        }
    }
    internal class SmallApartment : House
    {
        public SmallApartment() : base(50) { }

        public override void ShowData()
        {
            Console.WriteLine("I am an apartment, my area is " +
                area + " m2");
        }
    }
}
