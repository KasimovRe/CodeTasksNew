using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.IsPangram("The quick brown fox jumps over the lazy dog."));


        }
    }
    public static class Kata
    {
        public static bool IsPangram(string str)
        {
            char[] letters = Enumerable.Range('a', 'z' - 'a' + 1).Select(c => (char)c).ToArray();
            str.ToLower();

            return letters.All(str.Contains);

        }
    }
}
