using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collatz
{
    // Если число четное, разделите его на два.
    // Если число нечетное, утроите его и прибавьте единицу.
    // Если число один, закончите операцию.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Equals("3->10->5->16->8->4->2->1", Kata.Collatz1(3)));
        }
    }
    public class Kata
    {
        public static string Collatz1(int n)
        {
            List<int> numbers = new List<int> { n };
            while (n != 1)
                if (n % 2 == 0)
                    numbers.Add(n /= 2);
                else if (n % 2 == 1)
                    numbers.Add(n = (n * 3) + 1);
            return string.Join("->", numbers);
        }
    }
}
