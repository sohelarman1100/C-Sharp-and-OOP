using System;

namespace multi_level_inheritance
{
    public class Animal
    {
        public string legs, eat;
        public void display()
        {
            Console.WriteLine("no. of legs= {0}\nthey eat= {1}", legs, eat);
        }
    }

    public class live_land:Animal
    {
        public string runnig_status = "can run";
        public string lives_in = "land";
    }

    public class live_water:Animal
    {
        public string swiming_status = "can swim";
        public string lives_in = "water";
    }

    public class dog:live_land
    {
        public void set_val(string _legs, string _eat)
        {
            legs = _legs;
            eat = _eat;
        }
        public void display1()
        {
            Console.WriteLine("running status= {0}\nlives in= {1}\n", runnig_status, lives_in);
        }
    }
    public class fish:live_water
    {
        public void set_val(string _legs, string _eat)
        {
            legs = _legs;
            eat = _eat;
        }

        public void display1()
        {
            Console.WriteLine("swiming status= {0}\nlives in= {1}\n", swiming_status, lives_in);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dog dog1 = new dog();
            fish fish1 = new fish();
            Console.WriteLine("dog's information:");
            dog1.set_val("4", "meat");
            dog1.display();
            dog1.display1();
            Console.WriteLine("fish's information:");
            fish1.set_val("0", "insects and moss");
            fish1.display();
            fish1.display1();
        }
    }
}
