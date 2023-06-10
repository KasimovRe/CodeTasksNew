using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountForCharsInString
{
    internal class Task17me
    {
        static void Main(string[] args)
        {
            string str = "Russia";
            Console.WriteLine(Kata.DuplicateCount(str));

            Console.Read();
        }
    }
    public class Kata
    {
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
