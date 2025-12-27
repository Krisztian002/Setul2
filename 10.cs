using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int num = int.Parse(Console.ReadLine());
        int max = 1;
        int count = 1;

        for (int i = 1; i < n; i++)
        {
            int next = int.Parse(Console.ReadLine());
            if (next == num) count++;
            else count = 1;

            if (count > max) max = count;
            num = next;
        }

        Console.WriteLine(max);
    }
}
