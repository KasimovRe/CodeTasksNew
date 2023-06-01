using System;

public static class Clock1
{
    public static int Past(int h, int m, int s)
    {
        return (int)(new TimeSpan(h, m, s)).TotalMilliseconds; // TimeSpam при new можно использовать как метод
                                                               // и передать значение в часах, минутах и секундах
    }
}