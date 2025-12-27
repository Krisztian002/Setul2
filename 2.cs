using System;

class Program
{
    static void Main()
    {
        Console.Write("Introdu numarul de elemente: ");
        int n = int.Parse(Console.ReadLine());
        int negative = 0, zero = 0, positive = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Introdu elementul " + (i + 1) + ": ");
            int x = int.Parse(Console.ReadLine());

            if (x < 0)
                negative++;
            else if (x == 0)
                zero++;
            else
                positive++;
        }

        Console.WriteLine("Numere negative: " + negative);
        Console.WriteLine("Numere zero: " + zero);
        Console.WriteLine("Numere pozitive: " + positive);
    }
}
