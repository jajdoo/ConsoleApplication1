using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    class MainClass
    {
        public static void Main()
        {
            GenericO1Array<double> darr1;
            GenericO1Array<long> iarr1;
            int i;
            const int n = 20;

            darr1 = new GenericO1Array<double>(n, 1.1);
            iarr1 = new GenericO1Array<long>(n, 2);

            Console.WriteLine("\nLength.darr1 = {0}", darr1.Length);
            Console.WriteLine("\nLength.iarr1 = {0}", iarr1.Length);


            for (i = 0; i < n; i += 2)
            {
                darr1[i] = i * 10.0;
                iarr1[i] = i * 100;
            } // for


            Console.WriteLine("\ndarr1 = ");
            for (i = 0; i < n; i++)
                Console.WriteLine("darr1[{0}] = {1} ", i, darr1[i]);

            Console.WriteLine("\niarr1 = ");
            for (i = 0; i < n; i++)
                Console.WriteLine("iarr1[{0}] = {1} ", i, iarr1[i]);

            Console.ReadKey();
        } // Main

    } // MainClass

}
