using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double_dutor dd = new double_dutor(1.1);
            double_stack ds  = new double_stack(11.1);
            double_queue dq = new double_queue();
            double d;

            Console.WriteLine();   
            for(i=2; i < 14; i += 2)
            {
                dd.add_front((double)i*1.1); 
                dd.add_rear((double)((i+1)*1.1));
            } //for

            Console.WriteLine("dd print:");
            for(i=1; i < 14; i++)
            {
                dd.delete_front(out d);
                Console.Write("    " + d); 
            } // for

            Console.WriteLine();
            
            for(i=2; i < 14; i ++)
                ds.push((double)i*11.1);

            Console.WriteLine("\nds print:");
            
            for(i=1; i < 14; i++)
            {
                ds.pop(out d);
                Console.Write("    " + d);
            } // for
            
            Console.WriteLine();   
  
            for(i=1; i < 14; i ++)
                dq.enqueue((double)i*11.1); 
            
            Console.WriteLine("\ndq print:");
            
            for(i=1; i < 14; i++)
            {
                dq.dequeue(out d);
                Console.Write("    " + d);
            } // for
            Console.WriteLine();

            Console.ReadKey();
        } // main
    } // rundutor
}
