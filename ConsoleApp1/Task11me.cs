using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Task11me
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

            return letters.All(str.ToLower().Contains);

        }
    }
    public static class Kata1 // ответ с форума
    {
        public static bool IsPangram(string str)
        {
            return str.Where(ch => Char.IsLetter(ch)).Select(ch => Char.ToLower(ch)).Distinct().Count() == 26;
        }
    }
}
