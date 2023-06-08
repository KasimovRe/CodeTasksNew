using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NumberToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.NumberToEnglish(3680));

            Console.Read();
        }
    }

    // 0      -->  "zero"
    // 27     -->  "twenty seven"
    // 100    -->  "one hundred"
    // 7012   -->  "seven thousand twelve"
    // 99205  -->  "ninety nine thousand two hundred five"

    class Kata
    {
        public static string NumberToEnglish(int n)
        {
            string number = null;
            int i;

            if (n >= 0 && n <= 9)
            {
                i = Converter(n);
                number = ToNumberBaseBase(n, number, i);
            }
            else if (n >= 10 && n <= 99)
            {
                i = Converter(n);
                number = ToNumberBaseBase(n, number, i);
            }
            else if (n >= 100 && n <= 999)
            {
                i = Converter(n / 100);
                string newNumber = ToNumberBaseBase(n / 100, number, i);
                newNumber += " " + "hundred" + " ";

                i = Converter(n % 100 == 0 ? -1 : n % 100);
                string newTwoNumber = ToNumberBaseBase(n % 100, number, i);

                number = newNumber + newTwoNumber;
            }
            else if (n >= 1000 && n <= 9999) // 7012
            {
                i = Converter(n / 1000);
                string newNewNumber = ToNumberBaseBase(n / 1000, number, i);
                newNewNumber += " " + "thousand" + " ";

                n %= 1000; // 012

                i = Converter(n / 100 == 0 ? -1 : n / 100);
                string newNumber = ToNumberBaseBase(n / 100, number, i);
                if (n / 100 != 0) { newNumber += " " + "hundred" + " "; }

                i = Converter(n % 100 == 0 ? -1 : n % 100);
                string newTwoNumber = ToNumberBaseBase(n % 100, number, i);

                number = newNewNumber + newNumber + newTwoNumber;
            }
            else if (n >= 10000 && n <= 99999)
            {
                i = Converter(n / 1000);
                string newNewNumber = ToNumberBaseBase(n / 1000, number, i);
                newNewNumber += " " + "thousand" + " ";

                n %= 1000; // 012

                i = Converter(n / 100 == 0 ? -1 : n / 100);
                string newNumber = ToNumberBaseBase(n / 100, number, i);
                if (n / 100 != 0) { newNumber += " " + "hundred" + " "; }

                i = Converter(n % 100 == 0 ? -1 : n % 100);
                string newTwoNumber = ToNumberBaseBase(n % 100, number, i);

                number = newNewNumber + newNumber + newTwoNumber;
            }
            else number = "";

            while (number.Contains("  ")) { number = number.Replace("  ", " "); }
            return number.Trim();
        }

        public static int Converter(int i)
        {
            if (i >= 0 && i <= 9) { return 0; }
            else if (i >= 10 && i <= 99) { return 1; }
            else { return -1; }
        }
        public static string ToNumberBase(int n, string number)
        {
            switch (n)
            {
                case 0: number = "zero"; break;
                case 1: number = "one"; break;
                case 2: number = "two"; break;
                case 3: number = "three"; break;
                case 4: number = "four"; break;
                case 5: number = "five"; break;
                case 6: number = "six"; break;
                case 7: number = "seven"; break;
                case 8: number = "eight"; break;
                case 9: number = "nine"; break;
                case 10: number = "ten"; break;

                case 11: number = "eleven"; break;
                case 12: number = "twelve"; break;
            }
            return number;
        }
        public static string ToNumberDop(int n, string number)
        {
            switch (n)
            {
                case 1: number = "one"; break;
                case 2: number = "twen"; break;
                case 3: number = "thir"; break;
                case 4: number = "four"; break;
                case 5: number = "fif"; break;
                case 6: number = "six"; break;
                case 7: number = "seven"; break;
                case 8: number = "eight"; break;
                case 9: number = "nine"; break;
                case 10: number = "ten"; break;

                case 11: number = "eleven"; break;
            }
            return number;
        }
        public static string ToNumberDopDop(int n, string number)
        {
            switch (n)
            {
                case 1: number = "one"; break;
                case 2: number = "twen"; break;
                case 3: number = "thir"; break;
                case 4: number = "for"; break;
                case 5: number = "fif"; break;
                case 6: number = "six"; break;
                case 7: number = "seven"; break;
                case 8: number = "eigh"; break;
                case 9: number = "nine"; break;
                case 10: number = "ten"; break;

                case 11: number = "eleven"; break;
            }
            return number;
        }
        public static string ToNumberBaseBase(int n, string number, int i)
        {
            switch (i)
            {
                case 0:
                    {
                        number = ToNumberBase(n, number);
                    }
                    return number;

                case 1:
                    {
                        if (n == 10) { number = ToNumberDop(10, number); }
                        else if (n == 11) { number = ToNumberDop(11, number); }
                        else if (n == 12) { number = ToNumberBase(12, number); }
                        else if (n >= 13 && n <= 19)
                        {
                            int twoN = n % 10;
                            number = ToNumberDop(twoN, number);
                            number += "teen";
                        }

                        // n >= 20 && n <= 99
                        else
                        {
                            int oneN = n / 10;
                            int twoN = n % 10 == 0 ? -1 : n % 10;

                            number = ToNumberDopDop(oneN, number) + "ty" + " " + ToNumberBase(twoN, number);
                        }
                    }
                    return number;
            }
            return number;
        }
    }
}
