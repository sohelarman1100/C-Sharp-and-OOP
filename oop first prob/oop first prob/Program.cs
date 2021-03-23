using System;

namespace oop_first_prob
{
    public class stud
    {
        public int id;
        public string name;
        public void set_val(int k, string s)
        {
            id = k;
            name = s;
        }

        public void print()
        {
            Console.WriteLine("{0} is a good student and his id is {1}.",name,id);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            stud rakib = new stud();
            int roll = 10;
            string Name = "Rakib";
            rakib.set_val(roll, Name);
            rakib.print();
        }
    }
}
