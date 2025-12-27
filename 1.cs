using System;

class Program
{
    static void Main()
    {
        Console.Write("Câte numere vei introduce? ");
        int n = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Introdu un număr: ");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                count++;
            }
        }

        Console.WriteLine("Numere pare: " + count);
    }
}
