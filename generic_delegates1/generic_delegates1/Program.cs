using System;

namespace generic_delegates1
{
    public delegate int del<in T>(T num1, T num2);
    class check
    {
        int num1, num2;
        char c1, c2;
        public int int_pera(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
            return this.num1 + this.num2;
        }

        public int char_pera(char c1,char c2)
        {
            this.c1 = c1;
            this.c2 = c2;
            int res = (Convert.ToInt32(this.c1)-65) + (Convert.ToInt32(this.c2)-65);
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            check ck = new check();
            del<int> obj = ck.int_pera;
            int k = obj(5, 6);
            Console.WriteLine(k);
            del<char> obj1 = ck.char_pera;
            k = obj1('A', 'B');
            Console.WriteLine(k);
        }
    }
}
