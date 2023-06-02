using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumArray
{
    // найти произведение 2 максимальных чисел в массиве
    internal class Task7me
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.MaxProduct(new int[] { 56, 335, 195, 443, 6, 494, 252 }));
        }
    }

    public class Kata
    {
        public static int MaxProduct(int[] array)
        {
            Array.Sort(array);
            return array[array.Length - 1] * array[array.Length - 2];
        }
    }

    public class Kata1 // (ответ с коммов/ один из вариантов)
    {
        public static int MaxProduct(int[] array)
        {
            return array.OrderBy(x => -x).Take(2).Aggregate((a, b) => a * b);
        }
    }
}
