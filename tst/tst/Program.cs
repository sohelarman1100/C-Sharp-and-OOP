using System;
using System.Collections.Generic;

namespace tst
{
    class Program
    {
        static void Main(string[] args)
        {
            int k,i,j,m,n;
            List<int> lst = new List<int>();
            var inp = Console.ReadLine();
            var data = inp.Split(' ');
            k = inp.Length;
            Console.WriteLine(k);
            k = data.Length;
            for(i=0; i<k; i++)
            {
                m = int.Parse(data[i]);
                lst.Add(m);
            }
            //Console.WriteLine(k);

        }
    }
}
