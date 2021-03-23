using System;

namespace lambda_expression
{
    public delegate int lambda(int num1, int num2);
    class Program
    {
        static void Main(string[] args)
        {
            lambda del = (var1, var2) =>
              {
                  return var1 + var2;
              };
            int k = del(5, 10);
            Console.WriteLine(k);
        }
    }
}
