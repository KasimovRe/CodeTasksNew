using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsNazad
{
    internal class Task12me
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Solution("world"));
        }
    }
    public static class Kata
    {
        public static string Solution(string str)
        {
            char[] chars = new char[str.Length];
            int count = str.Length - 1;

            foreach (char simbol in str)
            {
                chars[count] = simbol;
                count--;
            }

            return string.Concat(chars);

        }
    }
    public static class Kata1 // решение с сайта
    {
        public static string Solution(string str)
        {
            return new string(str.ToArray().Reverse().ToArray());
        }
    }
}
