using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti un numar n: ");
        int n = int.Parse(Console.ReadLine());

        int suma = 0;
        int produs = 1;

        for (int i = 1; i <= n; i++)
        {
            suma += i;
            produs *= i;
        }

        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Produsul: " + produs);
    }
}
