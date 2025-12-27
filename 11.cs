using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int suma = 0;

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            int inv = 0;
            while (x > 0)
            {
                inv = inv * 10 + x % 10;
                x = x / 10;
            }
            suma += inv;
        }

        Console.WriteLine(suma);
    }
}
