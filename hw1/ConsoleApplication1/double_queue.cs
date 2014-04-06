using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hw1
{
    class double_queue
    {
        private double_dutor inner;

        public double_queue()
        {
            inner = new double_dutor();
        }

        internal void enqueue(double p)
        {
            inner.add_rear(p);
        }

        internal void dequeue(out double d)
        {
            inner.delete_front(out d);
        }
    }
}
