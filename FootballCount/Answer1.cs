using System.Linq;

public static class Kata1 // можно было решить так. 1 способ
{
    public static int TotalPoints1(string[] games)
    {
        return games.Sum(s => s[0] < s[2] ? 0 : s[0] == s[2] ? 1 : 3);
    }
}


