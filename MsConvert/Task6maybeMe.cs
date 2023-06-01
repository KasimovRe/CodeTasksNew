using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsConvert
{
    internal class Task6maybeMe
    {
        static void Main(string[] args)
        {
            int h = 0;
            int m = 1;
            int s = 1;

            Console.WriteLine(Clock.Past(h, m, s));
            Console.WriteLine(ClockClock.Past(h, m, s));
        }
    }
    public static class Clock
    {
        public static int Past(int h, int m, int s)
        {
            double sum = TimeSpan.FromHours(h).TotalMilliseconds + TimeSpan.FromMinutes(m).TotalMilliseconds + TimeSpan.FromSeconds(s).TotalMilliseconds;
            return (int)sum;
        }
    }
    public static class ClockClock
    {
        public static int Past(int h, int m, int s)
        {
            double hh = TimeSpan.FromHours(h).TotalMilliseconds;
            double mm = TimeSpan.FromMinutes(m).TotalMilliseconds;
            double ss = TimeSpan.FromSeconds(s).TotalMilliseconds;

            double sum = hh + mm + ss;
            return (int)sum;
        }
    }

}

