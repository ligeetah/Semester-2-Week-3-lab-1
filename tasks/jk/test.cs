using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks.jk
{
    internal class test
    {
        public test()
        {
            name = "MATEEN";
        }
        public test(test to_copy)
        {
            name=to_copy.name;
            age= to_copy.age;
            marks= to_copy.marks;
            gpa= to_copy.gpa;
        }
        public string name;
        public int age;
        public int marks;
        public float gpa;
    }
}
