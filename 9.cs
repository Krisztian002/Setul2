using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        bool cresc = true, desc = true;

        for (int i = 1; i < n; i++)
        {
            int y = int.Parse(Console.ReadLine());
            if (y > x) desc = false;
            if (y < x) cresc = false;
            x = y;
        }

        if (cresc || desc)
            Console.WriteLine("Secventa este monotona");
        else
            Console.WriteLine("Secventa nu este monotona");
    }
}
