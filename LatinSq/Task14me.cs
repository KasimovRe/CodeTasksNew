using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinSq
{
    internal class Task14me
    {
        static void Main(string[] args)
        {
            Kata.Latin(18);
        }
    }
    static class Kata
    {
        static public int[][] Latin(int n)
        {
            int[][] latinik = new int[n][];
            int count = 1;

            for (int i = 0; i < n; i++)
            {
                latinik[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    latinik[i][j] = count;
                    if (count == n)
                        count = 0;
                    count++;
                }
                    count++;
            }
            return latinik;
        }
    }
}
