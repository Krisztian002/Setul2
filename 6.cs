using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        bool crescator = true;

        for (int i = 1; i < n; i++)
        {
            int y = int.Parse(Console.ReadLine());
            if (x > y) crescator = false;
            x = y;
        }

        if (crescator)
            Console.WriteLine("Crescatoare");
        else
            Console.WriteLine("Nu sunt crescatoare");
    }
}
