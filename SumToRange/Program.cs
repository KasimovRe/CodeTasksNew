using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumToRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Summation1(4)); // = 10
        }
    }
    public static class Kata
    {
        public static int Summation(int num)
        {
            if (num - 1 == 0)
                return 1;
            return num + Summation(num - 1);
        }
        public static int Summation1(int num) => num - 1 == 0 ? 1 : num + Summation1(num - 1);
        public static int Summation2(int num) => Enumerable.Range(0, num).Sum();
    }
