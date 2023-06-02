using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqrtPwArray
{
    // если число можно вынести из квадрата
    // то вернуть квадрат. иначе в степень

    internal class Task9me
    {
        static void Main(string[] args)
        {
            var input = new int[] { 4, 3, 9, 7, 2, 1 };

            Kata.SquareOrSquareRoot(input);
        }
    }
    public class Kata
    {
        public static int[] SquareOrSquareRoot(int[] array)
        {
            int count = 0;
            foreach (int i in array)
            {
                array[count] = (int)(Math.Sqrt(i) % 1 == 0 ? Math.Sqrt(i) : Math.Pow(i, 2));
                Console.WriteLine(array[count]);
                count++;
            }

            return array;
        }
    }
}
