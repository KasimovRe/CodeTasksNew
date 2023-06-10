using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharsToString
{
    internal class Task16me
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Smash(new string[] { "hello", "world" }));
        }
    }
    public class Kata
    {
        public static string Smash(string[] words)
        {
            return string.Join(" ", words);
        }
    }
}
