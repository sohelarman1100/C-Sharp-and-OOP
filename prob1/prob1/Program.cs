using System;

namespace prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k=0, l, m, n;
            Console.Write("enter the value of n: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[n][];
            for(i = 0; i < n; i++)
            {
                Console.WriteLine("enter the row: ");
                var lst = Console.ReadLine();
                var data = lst.Split(' ');
                int[] ara = new int[data.Length];
                for(j=0; j<data.Length; j++)
                {
                    ara[j]= int.Parse(data[j]);
                }
                arr[i] = ara;
            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0} ", arr[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
