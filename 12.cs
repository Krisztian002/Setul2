using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int nrgrupe = 0;
        int x = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            int y = int.Parse(Console.ReadLine());
            if (x != 0 && y == 0) nrgrupe++;
            x = y;
        }

        if (x != 0) nrgrupe++;
        Console.WriteLine(nrgrupe);
    }
}
