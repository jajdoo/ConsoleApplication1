using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hw3
{
    class GenericO1Array<T> : AO1Array
    {
        // defualt vaule
        private T p;
        private T[] A;
        private int n;

        public int Length
        {
            get { return n; }
        }

        public GenericO1Array(int n, T p) : base(n)
        {
            this.n = n;
            this.p = p;
            A = new T[n];
        }

        public T this[int i]
        {
            get 
            {
                if (isInitialized(i))
                    return A[i];
                else
                    return p;
            }
            set 
            {
                initiIndex(i);
                A[i] = value;
            }
        }
    }
}
