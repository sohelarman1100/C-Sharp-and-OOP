using System;
using System.Collections.Generic;
using System.Linq;

namespace tst
{
    public class Program
    {
        static void Main(string[] args)
        {
            int k,i,j,m,n;
            List<int> lst = new List<int> { 1,2,3,4,5,6,7};
            var res = lst.Select((num, ind) => new { num = num, ind = ind }).Select(x => x.ind);
            foreach(var kn in res)
            {
                Console.WriteLine(kn);
            }
        }
    }
}
