using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hw2
{
    class Matrix
    {
        protected int n;
        public int N
        {
            get { return n; }
        }

        protected double[,] mat;
        public Matrix(int n)
        {
            this.n = n;
            mat = new double[n,n];
        }

        public Matrix()
        {
        }

        virtual public double this[int i, int j]
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
                    Console.Write(mat[i, j] + "\t");
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

        public static explicit operator double(Matrix A)
        {
            double sum = 0;
            foreach (double s in A.mat)
                sum += s;
            return sum;
        }

        public static Matrix operator *(Matrix A, Matrix B)
        {
            if (A.N != B.N)
                throw new InvalidOperationException("Cannot add two matrices of different dimensions!");

            Matrix C;
            if (A.N == 1)
            {
                C = new Matrix(1);
                C[0, 0] = A[0, 0] * B[0, 0];
                return C;
            }

            int size = A.N;

            A = prepForStrassen(A);
            B = prepForStrassen(B);

            Matrix
                A11 = A.get11Querter(), A12 = A.get12Querter(), A21 = A.get21Querter(), A22 = A.get22Querter(),
                B11 = B.get11Querter(), B12 = B.get12Querter(), B21 = B.get21Querter(), B22 = B.get22Querter(),
                C11, C12 , C21, C22,
                M1 , M2, M3, M4, M5 , M6, M7;

            M1 = (A11 + A22) * (B11 + B22);
            M2 = (A21 + A22) * B11;
            M3 = A11 * (B12 - B22);
            M4 = A22 * (B21 - B11);
            M5 = (A11 + A12) * B22;
            M6 = (A21 - A11) * (B11 + B12);
            M7 = (A12 - A22) * (B21 + B22);

            C11 = M1 + M4 - M5 + M7;
            C12 = M3 + M5;
            C21 = M2 + M4;
            C22 = M1 - M2 + M3 + M6;

            C = essemble(C11, C12, C21, C22);
            C.n = size;

            return C;
        }

        private Matrix get11Querter()
        {
            Matrix Q11 = new Matrix(N / 2);

            for (int i = 0; i < N / 2; i++)
                for (int j = 0; j < N / 2; j++)
                    Q11[i, j] = this[i, j];

            return Q11;
        }

        private Matrix get12Querter()
        {
            Matrix Q12 = new Matrix(N / 2);

            for (int i = 0; i < N / 2; i++)
                for (int j = 0; j < N / 2; j++)
                    Q12[i, j] = this[i, j + N / 2];

            return Q12;
        }

        private Matrix get21Querter()
        {
            Matrix Q21 = new Matrix(N/2);

            for (int i = 0; i < N / 2; i++)
                for (int j = 0; j < N / 2; j++)
                    Q21[i, j] = this[i + N / 2, j];

            return Q21;
        }

        private Matrix get22Querter()
        {
            Matrix Q22 = new Matrix(N/2);

            for (int i = 0; i < N / 2; i++)
                for (int j = 0; j < N / 2; j++)
                    Q22[i, j] = this[i + N / 2, j + N / 2];

            return Q22;
        }

        public static Matrix prepForStrassen(Matrix A)
        {
            if ( (A.N & A.N - 1) == 0 )
                return A;

            int n = (int)Math.Pow(2,Math.Ceiling(Math.Log(A.N, 2)));

            Matrix S = new Matrix(n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i >= A.N || j >= A.N)
                        S[i, j] = 0;
                    else
                        S[i, j] = A[i, j];
                }
            }

            return S;
        }

        public static Matrix essemble(Matrix Q11, Matrix Q12, Matrix Q21, Matrix Q22)
        {
            if (!(Q11.N == Q12.N && Q12.N == Q21.N && Q21.N == Q22.N))
                throw new InvalidOperationException("cannot essemble, matrices are of different dimensions");

            Matrix C = new Matrix(Q11.N * 2);

            for (int i = 0; i < C.N / 2; i++)
                for (int j = 0; j < C.N / 2; j++)
                    C[i, j] = Q11[i, j];

            for (int i = 0; i < C.N / 2; i++)
                for (int j = 0; j < C.N / 2; j++)
                    C[i, j + C.N / 2] = Q12[i, j];

            for (int i = 0; i < C.N / 2; i++)
                for (int j = 0; j < C.N / 2; j++)
                    C[i + C.N / 2, j] = Q21[i, j];

            for (int i = 0; i < C.N / 2; i++)
                for (int j = 0; j < C.N / 2; j++)
                    C[i + C.N / 2, j + C.N / 2] = Q22[i, j];

            return C;
        }
    }
}
