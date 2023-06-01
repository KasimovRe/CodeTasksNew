using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FootballCount
{
    // Нам нужно написать функцию, которая берет этот набор и возвращает количество очков,
    // которое наша команда (x) набрала в чемпионате по приведенным выше правилам.

    // 0 <= х <= 4
    // 0 <= у <= 4

    // если x > y: 3 очка(победа)
    // если x < y: 0 очков (проигрыш)
    // если x = y: 1 балл (ничья)
    internal class Task3me
    {
        static void Main(string[] args)
        {
            string[] games = { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" }; // x | y

            int count = Kata.TotalPoints(games);
            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
    public static class Kata
    {
        public static int TotalPoints(string[] games)
        {
            int x = 0;

            for (int i = 0; i < games.Length; i++)
            {
                games[i] = games[i].Replace(':', ' '); // заменяет старые жлементы на новые
                var temp = games[i].Split(' '); // возвращает значения между которыми этот символ в виде листа

                var countX = int.Parse(temp[0]);
                var countY = int.Parse(temp[1]);

                if (countX > countY) { x += 3; }
                else if (countX < countY) { }
                else if (countY == countX) { x += 1; }
                else { Console.WriteLine("Error"); }
            }
            return x;
        }
    }
}
