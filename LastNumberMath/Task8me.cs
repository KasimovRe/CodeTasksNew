using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastNumberMath
{
    // вернуть последнюю цифру числа a^b,
    // где а = основание, b = степень
    internal class Task8me
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LastDigit.GetLastDigit(2, 6)); // 64 - 4
            Console.WriteLine(LastDigit.GetLastDigit(10, 10)); // 100 - 0
            Console.WriteLine(LastDigit.GetLastDigit(3, 3)); // 27 - 7
            Console.WriteLine(LastDigit.GetLastDigit(9, 2)); // 81 - 1
        }
    }
    class LastDigit // ответ на сайте такой же)
    {
        public static int GetLastDigit(BigInteger n1, BigInteger n2)
        {
            return (int)BigInteger.ModPow(n1, n2, 10); 
        }
    }
}
