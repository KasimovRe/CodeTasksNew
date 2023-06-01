using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSinClub
{
    // Чтобы быть Sinior, член должен быть не моложе 55 лет
    // и иметь гандикап больше 7. В этом крокетном клубе гандикап
    // варьируется от -2 до +26; чем лучше игрок, тем ниже гандикап.

    // input =  [[18, 20], [45, 2], [61, 12], [37, 6], [21, 21], [78, 9]]
    // output = ["Open", "Open", "Senior", "Open", "Open", "Senior"]

    internal class Task4me
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.OpenOrSenior(
                new[]
                {
                    new[] { 45, 12 },
                    new[] { 55, 21 },
                    new[] { 19, 2 },
                    new[] { 104, 20 }
                }
                ));
            // { "Open", "Senior", "Open", "Senior" };

            Console.ReadKey();
        }
    }
    public class Kata
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            string[] catigories = new string[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                catigories[i] = (data[i][0] >= 55) && (data[i][1] > 7) && ((data[i][1] >= -2) && (data[i][1] <= 26)) ? "Senior" : "Open";
            }

            return catigories;
        }
    }
}
