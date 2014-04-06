using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class double_dutor
    {
        private double_node front;
        private double_node rear;

        public double_dutor()
        {
        }

        public double_dutor(double p)
        {
            rear = front = new double_node(p);
        }

        public void add_front(double p)
        {
            double_node newfront = new double_node(p);

            if (front == null && rear == null)
                rear = front = newfront;
            else
            {
                front.next = newfront;
                newfront.prev = front;
                front = newfront;
            }
        }

        public void add_rear(double p)
        {
            double_node newrear = new double_node(p);

            if (front == null && rear == null)
                rear = front = newrear;
            else
            {
                rear.prev = newrear;
                newrear.next = rear;
                rear = newrear;
            }
        }

        public void delete_front(out double d)
        {
            if (front == null)
                throw new InvalidOperationException("no elements to remove");

            d = front.value;
            front = front.prev;

            if (front != null)
                front.next = null;
            else
                rear = null;
        }

        public void delete_rear(out double d)
        {
            if (rear == null)
                throw new InvalidOperationException("no elements to remove");

            d = rear.value;
            rear = rear.next;

            if (rear != null)
                rear.prev = null;
            else
                front = null;
        }
    }
}
