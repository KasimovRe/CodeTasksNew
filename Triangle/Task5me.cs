using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    // Треугольник существует только тогда, когда сумма двух его сторон больше третьей

    // Реализуйте функцию, которая принимает 3 целочисленных значения a, b, c.
    // Функция должна возвращать true, если можно построить треугольник
    // со сторонами заданной длины, и false в любом другом случае.

    // (В этом случае все треугольники должны иметь поверхность больше 0, чтобы быть принятыми).

    internal class Task5me
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Triangle1.IsTriangle(4, 2, 3));
            Console.ReadKey();
        }
    }
    public class Triangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            return Math.Max(Math.Max(b, c), a) < Math.Min(Math.Min(b, c), a) + Math.Min(Math.Max(b, c), a);
        }
    }
    public class Triangle1
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            int max = a > b ? a : b;
            max = max > c ? max : c;

            int sum = max == a ? (b + c) : (max == c ? (a + b) : (c + a));

            return max < sum;
        }
    }
}
