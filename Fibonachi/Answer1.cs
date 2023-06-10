namespace Fibonachi
{
    public class Fibonacci1 // 1
    {
        public static int fib(int n)
        {
            return n < 3 ? 1 : fib(n - 1) + fib(n - 2);
        }
    }
}
