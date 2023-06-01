using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepestki
{
    // Если у одного из цветов четное количество лепестков,
    // а у другого нечетное количество лепестков, это означает, что они влюблены.

    // Напишите функцию, которая будет принимать количество лепестков
    // каждого цветка и возвращать true, если они влюблены, и false, если нет.
    internal class Task4me
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LoveDetector.Lovefunc(5, 5));
            Console.ReadKey();
        }
    }
    public class LoveDetector
    {
        public static bool Lovefunc(int flower1, int flower2)
        {
            return (flower1 % 2 == 0 && flower2 % 2 != 0) || (flower2 % 2 == 0 && flower1 % 2 != 0) ? true : false;
        }
    }
}
