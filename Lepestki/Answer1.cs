using System;

public class LoveDetector1
{
    public static bool Lovefunc(int flower1, int flower2)
    {
        return flower1 % 2 != flower2 % 2;
    }
}