using System;

namespace generic_class
{
    public class generic_class<tp>
    {
        private tp data;
        public tp inp
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
    }
    class Test
    {

        static void Main(string[] args)
        {
            generic_class<string> name = new generic_class<string>();
            name.inp = "Bangladesh";
            generic_class<float> version = new generic_class<float>();
            version.inp = 5.0F;

            Console.WriteLine(name.inp);
            Console.WriteLine(version.inp);
        }
    }
}
