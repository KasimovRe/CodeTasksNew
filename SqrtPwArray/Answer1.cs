using System;
using System.Linq;

namespace SqrtPwArray
{
    public class Kata1 // с помощью селекта, который перебирает массив
                       // где х это все значения. и конвертируем в массив
                       // то есть возвращаем массив
    {
        public static int[] SquareOrSquareRoot(int[] array)
        {
            return array.Select(x => (int)(Math.Sqrt(x) % 1 == 0 ? Math.Sqrt(x) : Math.Pow(x, 2))).ToArray(); 
        }
    }
}
    