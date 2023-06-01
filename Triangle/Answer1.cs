using System.Collections.Generic;

public class Triangle1
{
    public static bool IsTriangle(int a, int b, int c) // можно было рил с помощью сортировки
    {
        var lengths = new List<int>() { a, b, c };
        lengths.Sort();
        return lengths[0] + lengths[1] > lengths[2];
    }
}