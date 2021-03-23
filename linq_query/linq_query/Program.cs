using System;
using System.Collections.Generic;  //dictionary,Arraylist,List,HashSet
using System.Collections;   //arraylist er jonno lage
using System.Linq;


namespace linq_query
{
    class Program
    {
        static void Main(string[] args)
        {
            var lst = new List<int>();

            int i, j, l,n;

            n=Convert.ToInt32(Console.ReadLine());

            var inp = Console.ReadLine();

            var val = inp.Split(' ');

            for(i=0; i<val.Length; i++)
            {
                int k= int.Parse(val[i]);
                lst.Add(k);
            }


            IEnumerable<int> data =
            from num in lst
                  where num>5 && (Convert.ToBoolean(num % 2==0))
                  orderby num descending
                  select num;

            foreach (int p in data)
            {
                Console.Write("{0} ", p);
            }
            Console.WriteLine();


            var data1 = from num in lst
                       group num by num % 2 == 0 into evn
                       select evn;


            foreach (var p in data1)
            {
                Console.Write("{0} ", p.Key);
                foreach(var q in p)
                {
                    Console.WriteLine("num= {0}", q);
                }
            }
            Console.WriteLine();



            var even = lst.Where(num => (num%2) == 0).ToList();
            for(int p=0; p<even.Count; p++)
            {
                Console.Write("{0} ",even[p]);
            }

        }
    }
}
