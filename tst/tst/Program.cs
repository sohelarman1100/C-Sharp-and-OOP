using System;
using System.Collections.Generic;

namespace tst
{
    public class Program
    {
        public int add(params int[] ara)
        {
            int i, res = 0;
            for(i=0; i<ara.Length;i++)
            {
                res += ara[i];
            }
            return res;
        }
        static void Main(string[] args)
        {
            int k,i,j,m,n;
            //List<int> lst = new List<int>();
            var inp = Console.ReadLine();
            var data = inp.Split(' ');
            //k = inp.Length;
            //Console.WriteLine(k);
            k = data.Length;
            int[] lst = new int[k];
            for(i=0; i<k; i++)
            {
                m = int.Parse(data[i]);
                lst[i] = m;
            }
            Program obj = new Program();
            m = obj.add(lst);
            Console.WriteLine(m);

        }
    }
}
