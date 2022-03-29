using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tasks.jk;

namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            test test = new test();
            Console.Write("Empty Time :> ");
            test.print_time();
            test test1 = new test(8);
            Console.Write("Empty Time :> ");
            test1.print_time();
            test test2 = new test(8,30);
            Console.Write("Empty Time :> ");
            test2.print_time();
            test test3 = new test(8,30,55);
            Console.Write("Empty Time :> ");
            test3.print_time();
            test3.increment_hours();
            Console.Write("Time :> ");
            test3.print_time();
            test3.increment_min();
            Console.Write("Time :> ");
            test3.print_time();
            test3.increment_sec();
            Console.Write("Time :> ");
            test3.print_time();
            bool flag=test3.is_equal(3,40, 55);
            Console.WriteLine("Flag :> "+flag);
            test clk = new test(9,31,56);
            flag = test3.is_equal(clk);
            Console.WriteLine("Flag :> " + flag);
            Console.ReadKey();
        }
    }
}
