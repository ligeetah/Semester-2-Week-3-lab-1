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
            List<test> numbers = new List<test>();
            for (int i = 0; i < 5; i++)
            {
                test r=new test();
                r.num = i+1;
                numbers.Add(r);
            }
            foreach(var i in numbers)
            {
                Console.WriteLine(i.num);
            }
            Console.ReadKey();
        }
    }
}
