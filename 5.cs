using System;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x == i)
                count++;
        }

        Console.WriteLine(count);
    }
}
