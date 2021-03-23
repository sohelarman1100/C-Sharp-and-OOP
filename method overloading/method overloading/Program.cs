using System;

namespace method_overloading
{
    public class Calculation
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int add(int a, int b, int c)   // overloading add method by no. of perameter
        {
            return a + b + c;
        }

        public float add(float a, float b)     //overloading add method by data type
        {
            return a + b;
        }
    }

    public class TestMemberOverloading
    {
        public static void Main()
        {
            Calculation objt = new Calculation();
            int sum1 = objt.add(10, 15);     //calling 1st add method
            int sum2 = objt.add(5, 3, 2);     //calling 2nd add method
            float sum3 = objt.add(5.5f, 5.5f);   //calling 3rd add method
            Console.WriteLine("{0}  {1} {2}",sum1,sum2,sum3);
        }
    }

}
