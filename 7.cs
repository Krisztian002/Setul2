using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int min = x, max = x;
        for (int i = 1; i < n; i++)
        {
            int y = int.Parse(Console.ReadLine());
            if (y < min) min = y;
            if (y > max) max = y;
        }
        Console.WriteLine(max + " " + min);
    }
}
