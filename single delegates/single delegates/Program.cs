using System;

namespace single_delegates
{
    public delegate int calculator(int first_num, int second_num);

    class selling_detail
    {
        public int mobile_phone, laptop;
        public int add(int mbl, int lptop)
        {
            mobile_phone = mbl;
            laptop = lptop;
            int total = mobile_phone + laptop;
            return total;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            selling_detail obj = new selling_detail();
            calculator cal = new calculator(obj.add); //pointing add method by delegate
            int k = cal(11000, 50000);
            Console.WriteLine(k);
        }
    }
}
