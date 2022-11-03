using System;

namespace CSharp
{
    class Program
    {
        static int Factorial(int a)
        {
            // base case
            if(a <= 1)
            {
                return 1;
            }

            // recursive case
            return a * Factorial(a - 1);
        }
        static void Main(string[] args)
        {
            int ret = Factorial(5);

            Console.WriteLine(ret);
        }
    }
}

