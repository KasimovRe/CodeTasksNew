using System;
using System.Collections.Generic;
using System.Linq;

namespace TrollComm2
{
    // Написать метод, удаляющий все гласные в слове

    public static class Deleter
    {
        public static string Returns(this string str)
        {
            List<char> simbols = new List<char> // помещаем в лист все запретные значения
                                                // типа char или string - без разницы
            {
                'a', 'o', 'e', 'i', 'u',
                'A', 'O', 'E', 'I', 'U'
            };
            foreach (char item in simbols) // 
            {
                str = str.Replace(item.ToString(), null);
            }
            return str;
        }
    }
    internal class Task1me
    {

        static void Main(string[] args)
        {
            string str = "Haha, God is Evil";

            str = Deleter.Returns(str);
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}

