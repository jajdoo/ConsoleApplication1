using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hw1
{
    class double_stack
    {
        private double_dutor inner;

        public double_stack(double p)
        {
            inner = new double_dutor(p);
        }

        public void push(double p)
        {
            inner.add_front(p);
        }

        public void pop(out double d)
        {
            inner.delete_front(out d);
        }
    }
}
