using System;
using System.Collections;
using System.Collections.Generic;

namespace second
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, l;
            string s = Console.ReadLine();
            Queue<int> stk = new Queue<int>();
            for(i=0; i<s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    k = s[i] - 48;
                    stk.Enqueue(k);
                }
            }

            Console.WriteLine(stk.Count);
            //k=stk.Peek();
            //Console.WriteLine(k);
            //stk.Pop();
            //k=stk.Peek();
            //Console.WriteLine(k);
            foreach(var v in stk)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine();
            if (stk.Contains(5) == true)
                Console.WriteLine("Arman");
            else
                Console.WriteLine("Sohel");
        }
    }
}
