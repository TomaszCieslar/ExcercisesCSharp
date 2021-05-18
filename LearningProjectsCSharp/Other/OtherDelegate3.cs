using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.Other
{
    public delegate void MaximumTermReachedHandler(object source, EventArgs e);

    public class OtherDelegate3
    {
        public void Main()
        {
            Loan loan = new Loan();
            loan.Term = 12;
            Console.WriteLine("Hello World!");
        }
    }

    public class Loan
    {
        private int _term;
        private const int MaximumTem = 10;
        private const decimal Rate = 0.034m;
        public event MaximumTermReachedHandler OnMaximumTermReached;
        public int Term
        {
            get
            {
                return _term;
            }
            set
            {
                if (value <= MaximumTem)
                {
                    _term = value;
                }
                else
                {
                    if (OnMaximumTermReached != null)
                    {
                        OnMaximumTermReached(this, new EventArgs());
                    }
                }
            }
        }
    }
}
