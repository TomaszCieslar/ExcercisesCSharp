using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.Delegates
{
    class DelegatesAddingMultipleDelegates
    {
        public delegate void WorkPerformanceHandler(int hours, WorkType workType);
        static void Main(string[] args)
        {
            WorkPerformanceHandler del1 = new WorkPerformanceHandler(WorkPerformed1);
            WorkPerformanceHandler del2 = new WorkPerformanceHandler(WorkPerformed2);
            WorkPerformanceHandler del3 = new WorkPerformanceHandler(WorkPerformed3);


            del1 += del2 + del3;

            del1(10, WorkType.GenerateReports);

            Console.ReadLine();
        }

        static void DoWork(WorkPerformanceHandler del)
        {
            del(5, WorkType.GotoMeeting);
        }

        static void WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed1 called " + hours.ToString());
        }

        static void WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed2 called " + hours.ToString());
        }

        static void WorkPerformed3(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed3 called " + hours.ToString());
        }
    }
    public enum WorkType2
    {
        GotoMeeting,
        Golf,
        GenerateReports

    }
}
