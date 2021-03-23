using System;

namespace generic_method
{
    class genericMethod
    {
        public int sum_display<mytyp>(int k,mytyp n)
        {
            int m = Convert.ToInt32(n);
            m = m + k;
            return m;
            //Console.WriteLine("the sum is= {0}", k + m);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            genericMethod obj = new genericMethod();
            int k= obj.sum_display<string>(5, "15");
            Console.WriteLine("the sum is= {0}", k);
        }
    }
}
