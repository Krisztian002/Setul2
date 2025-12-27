using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti n: ");
        int n = int.Parse(Console.ReadLine());
        int a = 0, b = 1, c = 0;

        if (n == 1)
            c = 0;
        else if (n == 2)
            c = 1;
        else
        {
            for (int i = 3; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
        }

        Console.WriteLine("Al " + n + "-lea numar Fibonacci este: " + c);
    }
}
