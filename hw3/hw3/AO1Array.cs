using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    abstract class AO1Array 
    {
        private int[] B;
        private int[] C;
        private int top;

        public AO1Array(int n)
        {
            B = new int[n];
            C = new int[n];
            top = 0;
        }

        /** init index
         *  if index is initialized, does nothing.
         */
        protected void initiIndex(int i)
        {
            if ( !isInitialized(i) )
            {
                C[top] = i;
                B[i] = top;
                top++;
            }
        }

        protected bool isInitialized(int i)
        {
            if (0 <= B[i] && B[i] < top && C[B[i]] == i)
                return true;

            return false;
        }
    }
}
