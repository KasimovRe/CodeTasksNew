using System;

public class LoveDetector2
{
    public static bool Lovefunc(int flower1, int flower2)
    {
        return (flower1 + flower2) % 2 == 1;
    }
}