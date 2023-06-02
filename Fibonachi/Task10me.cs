using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
    internal class Program
    {
        // возвращает n-й элемент последовательности Фибоначчи
        // 0 + 1 = 1
        // 1 + 2 = 3
        // 2 + 3 = 5
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci.Fib1(5));
            Console.WriteLine(Fibonacci.Fib1(10));

            Console.WriteLine(Fibonacci.Fib1(3));
        }
    }
    public class Fibonacci
    {
        public static int Fib(int n)
        {
            int[] fib = new int[n + 1];


            for (int i = 0; i <= n; i++)
            {
                if (i == 0)
                    fib[i] = 0;
                else if (i == 1)
                    fib[i] = 1;
                else if (i > 1)
                    fib[i] = fib[i - 1] + fib[i - 2];
            }

            return fib[n];
        }

        public static int Fib1(int n)
        {
            int[] fib = new int[n + 1];

            for (int i = 0; i <= n; i++)
                fib[i] = i == 0 ? fib[i] = 0 : (i == 1 ? fib[i] = 1 : (fib[i - 2] + fib[i - 1]));

            return fib[n];
        }
    }
}
