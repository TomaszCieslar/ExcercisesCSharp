using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.Delegates
{
    class DelegatesCreatingCustomDelegate
    {
        public delegate void WorkPerformanceHandler(int hours, WorkType workType);
        static void Main(string[] args)
        {
            WorkPerformanceHandler del1 = new WorkPerformanceHandler(WorkPerformed1);
            WorkPerformanceHandler del2 = new WorkPerformanceHandler(WorkPerformed2);

            del1(5, WorkType.Golf);
            del2(10, WorkType.GenerateReports);
        }

        static void WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed1 called " + hours.ToString());
        }

        static void WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed2 called " + hours.ToString());
        }
    }

    public enum WorkType
    {
        GotoMeeting,
        Golf,
        GenerateReports
    }
}

