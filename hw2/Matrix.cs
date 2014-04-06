using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hw2
{
    class Matrix
    {
        private int n;
        public int N
        {
            get { return n; }
        }

        private double[,] mat;
        public Matrix(int n)
        {
            this.n = n;
            mat = new double[n,n];
        }

        public double this[int i, int j]
        {
            set { mat[i, j] = value; }
            get { return mat[i, j]; }
        }

        public void print()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static Matrix operator +(Matrix l, Matrix r)
        {
            if (l.N != l.N)
                throw new InvalidOperationException("Cannot add two matrices of different dimensions!");

            Matrix m = new Matrix(l.N);

            for (int i = 0; i < l.N; i++)
                for (int j = 0; j < l.N; j++)
                    m[i, j] = l[i, j] + r[i, j];

            return m;
        }

        public static Matrix operator -(Matrix l, Matrix r)
        {
            if (l.N != l.N)
                throw new InvalidOperationException("Cannot add two matrices of different dimensions!");

            Matrix m = new Matrix(l.N);

            for (int i = 0; i < l.N; i++)
                for (int j = 0; j < l.N; j++)
                    m[i, j] = l[i, j] - r[i, j];

            return m;
        }
    }
}
