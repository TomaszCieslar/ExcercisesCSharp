using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.Other
{
    public class OtherActivatorExample
    {
        public void Main()
        {
            Type type1 = typeof(MyClass);



            object obj = Activator.CreateInstance(type1);


            Console.WriteLine(type1.ToString());
            Console.WriteLine(obj.ToString());
            Console.ReadLine();
        }
        
    }
    class MyClass
    {

    }
}
