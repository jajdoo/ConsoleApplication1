using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hw1
{
    class double_node
    {
        public double value
        {
            get;
            set;
        }

        public double_node prev
        {
            get;
            set;
        }

        public double_node next
        {
            get;
            set;
        }

        public double_node(double v)
        {
            value = v;
            next = null;
            prev = null;
        }
    }
}
