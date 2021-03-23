using System;

namespace Inheritance1
{
    public class Animal1
    {
        public int leg = 4;
        public int eye = 2;
        public string eat;
        public string lives_in;
        public void set_val(string s1, string s2)
        {
            eat = s1;
            lives_in = s2;
        }

        public void display()
        {
            Console.WriteLine("no. of leg= {0}\nno. of eye= {1}\neat= {2}\nlives in= {3}\n", leg, eye, eat, lives_in);
        }
    }

    public class dog:Animal1
    {
        public string name;
        public void display1()
        {
            Console.WriteLine("name= {0}", name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dog dg = new dog();
            dg.name = "Dog";
            dg.set_val("meat", "everywhere");
            dg.display1();
            dg.display();
        }
    }
}
