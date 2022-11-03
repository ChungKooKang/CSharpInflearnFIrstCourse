using System;

namespace CSharp
{
    class Program
    {
        static int Factorial(int a)
        {
            int ret = 1;

            for (int num = 1; num < a; num++)
            {
                ret *= num;
            }

            return ret;
        }
        static void Main(string[] args)
        {
            int ret = Factorial(5);

            Console.WriteLine(ret);
        }
    }
}

