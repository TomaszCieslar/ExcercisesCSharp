using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.Other
{
    public class OtherAsyncStreams1
    {
        public void Main()
        {
            Console.WriteLine("Hello World!");
        }
        public struct SensorData
        {
            public SensorData(int value1, int value2) => (Value1, Value2) = (value1, value2);

            public int Value1 { get; }
            public int Value2 { get; }

        }

        //Available in c# 8
        public class Adevice
        {
            public async IAsyncEnumerable
        }
    }
}
