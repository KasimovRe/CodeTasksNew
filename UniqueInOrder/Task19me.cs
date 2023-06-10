using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueInOrder
{
    internal class Task19me
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Equals("ABCDAB", Kata.UniqueInOrder("AAAABBBCCDAABBB")));
        }
    }

    public static class Kata
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            iterable.OfType<T>().ToList();
            return iterable;
        }
        public static int DuplicateCount(string str)
        {
            List<char> chars = str.ToLower().ToList();
            chars.Sort();

            int count = 0;

            for (int i = 0; i < chars.Count; i++)
            {
                for (int j = i + 1; j < chars.Count; j++)
                {
                    if (chars[i] == chars[j])
                    {
                        if (chars[j] == ' ')
                            break;
                        while (chars[i] == chars[j])
                        {
                            chars.Remove(chars[j]);
                            chars.Add(' ');
                        }
                        count += 1;
                        j--;
                    }
                }
            }
            return count;
        }
    }
}
