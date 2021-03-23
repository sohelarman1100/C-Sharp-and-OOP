using System;
using System.Collections.Generic;  //dictionary,Arraylist,List,HashSet

using System.Collections;   //arraylist er jonno lage
using System.Linq;

namespace linq_query1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, l, n;
            n = Convert.ToInt32(Console.ReadLine());
            var lst = new List<int>();

            var inp = Console.ReadLine();
            var data = inp.Split(' ');
            for(i=0; i<data.Length; i++)
            {
                k = int.Parse(data[i]);
                lst.Add(k);
            }

            var q= lst.Where(x => (x % 3) == 0).ToList();

            for (i = 0; i <q.Count; i++)
                Console.Write("{0} ", q[i]);
            Console.WriteLine();
        }
    }
}
