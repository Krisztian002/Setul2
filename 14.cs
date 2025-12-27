using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int primul = int.Parse(Console.ReadLine());
        int x = primul;
        int cresc = 0;
        int desc = 0;

        for (int i = 1; i < n; i++)
        {
            int y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                cresc++;
            }
            if (x < y)
            {
                desc++;
            }
            x = y;
        }

        if ((cresc <= 1 && x <= primul) || (desc <= 1 && x >= primul))
        {
            Console.WriteLine("Secventa de numere este o secventa monotona rotita");
        }
        else
        {
            Console.WriteLine("Secventa de numere nu este o secventa monotona rotita");
        }
    }
}
