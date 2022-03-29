using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks.jk
{
    internal class test
    {
        public int hr;
        public int min;
        public int sec;
        public test()
        {
            hr = 0;
            min = 0;
            sec = 0;
        }
        public test(int h)
        {
            hr = h;
        }
        public test(int h,int m)
        {
            hr = h;
            min = m;
        }
        public test(int h,int m,int s)
        {
            hr = h;
            min = m;
            sec = s;
        }
        public void increment_sec()
        {
            sec++;
        }
        public void increment_min()
        {
            min++;
        }
        public void increment_hours()
        {
            hr++;
        }
        public void print_time()
        {
            Console.WriteLine(hr+" : "+min+" : "+sec);
        }
        public bool is_equal(int h,int m,int s)
        {
            if(hr==h &&min==m&&sec==s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool is_equal(test ch)
        {
            if (hr == ch.hr && min == ch.min && sec == ch.sec)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
