using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.Delegates
{
    public delegate void WorkPerformanceHandler(object sender, WorkPerformedEventArgs e);

    public enum WorkType3
    {
        GotoMeeting,
        Golf,
        GenerateReports

    }

    class DelegatesDefiningEvents
    {
        static void Main(string[] args)
        {
            //WorkPerformanceHandler del1 = new WorkPerformanceHandler(WorkPerformed1);
            //WorkPerformanceHandler del2 = new WorkPerformanceHandler(WorkPerformed2);
            //WorkPerformanceHandler del3 = new WorkPerformanceHandler(WorkPerformed3);


            //del1 += del2 + del3;

            //del1(10, WorkType.GenerateReports);
            var worker = new Worker();
            worker.WorkPerformed += Worker_WorkPerformed;
            worker.WorkCompleted += Worker_WorkCompleted;
            worker.DoWork(8, WorkType3.GenerateReports);


            Console.ReadLine();
        }

        private static void Worker_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Work completed");
        }

        private static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine(e.Hours + " " + e.WorkType);
        }

        //static void DoWork(WorkPerformanceHandler del)
        //{
        //    del(5, WorkType.GotoMeeting);
        //}

        //static void WorkPerformed1(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed1 called " + hours.ToString());
        //}

        //static void WorkPerformed2(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed2 called " + hours.ToString());
        //}

        //static void WorkPerformed3(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed3 called " + hours.ToString());
        //}
    }

    public class WorkPerformedEventArgs : EventArgs
    {

        public WorkPerformedEventArgs(int hours, WorkType3 workType)
        {
            Hours = hours;
            WorkType = workType;
        }

        public int Hours { get; set; }
        public WorkType3 WorkType { get; set; }
    }


    public class Worker
    {


        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType3 workType)
        {
            for (int i = 0; i < hours; i++)
            {
                System.Threading.Thread.Sleep(1000);
                OnWorkPerformed(i + 1, workType);
            }
            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int hours, WorkType3 workType)
        {
            var del = WorkPerformed as EventHandler<WorkPerformedEventArgs>;
            if (del != null)
            {
                del(this, new WorkPerformedEventArgs(hours, workType));
            }
        }

        protected virtual void OnWorkCompleted()
        {
            var del = WorkCompleted as EventHandler;
            if (del != null)
            {
                del(this, EventArgs.Empty);
            }
        }
    }
}