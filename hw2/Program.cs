using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Program
    {
        static void Main(String[] argv)
        {
            int n = 5, i, j;
            Matrix M1 = new Matrix(n), M2 = new Matrix(n), M3 = new Matrix(n);
            double d;

            for (i = 0; i < M1.N; i++)
                for (j = 0; j < M1.N; j++)
                {
                    M1[i, j] = i + 10 * j;
                    M2[i, j] = 100 * i + j;
                } // for

            Console.WriteLine("M1:");
            M1.print();
            Console.WriteLine("M2:");
            M2.print();

            Console.WriteLine("M1 + M2:");
            M3 = M1 + M2;
            M3.print();
           /* M3 = M1 * M2;
            Console.WriteLine("M1 * M2:");
            M3.print();

            d = (double)M1;
            Console.WriteLine("\n(double)M1 = " + d);
            */
        }
        /*
        static void Main()
        {
            int n = 5, i, j;
            Sym_Matrix M1 = new Sym_Matrix(n), M2 = new Sym_Matrix(n), M3 =
            new
            Sym_Matrix(n);
            double d;

            for (i = 0; i < M1.N; i++)
                for (j = 0; j < M1.N; j++)
                {
                    M1[i, j] = i + 10 * j;
                    M2[i, j] = 100 * i + j;
                } // for

            Console.WriteLine("M1:");
            M1.print();
            Console.WriteLine("M2:");
            M2.print();

            Console.WriteLine("M1 + M2:");
            M3 = M1 + M2;
            M3.print();
            M3 = M1 * M2;
            Console.WriteLine("M1 * M2:");
            M3.print();

            d = (double)M1;
            Console.WriteLine("\n(double)M1 = " + d);
        } // Main*/
    }
}
