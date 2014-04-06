using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hw2
{
    class Sym_Matrix : Matrix
    {
        public Sym_Matrix(int n) : base(n)
        {
        }

        public Sym_Matrix(Matrix m)
        {
            n = m.N;
            this.mat = new double[m.N,m.N];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    this[i, j] = m[i, j];
            
        }

        override public double this[int i, int j]
        {
            set { mat[i, j] = value; mat[j,i] = value;  }
            get { return mat[i, j]; }
        }

        public static Sym_Matrix operator +(Sym_Matrix l, Sym_Matrix r)
        {
            return new Sym_Matrix((Matrix)l + (Matrix)r);
        }


        public static Sym_Matrix operator -(Sym_Matrix l, Sym_Matrix r)
        {
            return new Sym_Matrix((Matrix)l + (Matrix)r);
        }

        public static Sym_Matrix operator *(Sym_Matrix l, Sym_Matrix r)
        {
            return new Sym_Matrix((Matrix)l * (Matrix)r);
        }
    }
}
