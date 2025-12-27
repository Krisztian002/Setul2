using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int schimb = 0, status = 0;

        for (int i = 1; i < n; i++)
        {
            int y = int.Parse(Console.ReadLine());
            if (y > x)
            {
                if (status == -1) schimb++;
                status = 1;
            }
            else if (y < x)
            {
                if (status == 1) schimb++;
                status = -1;
            }
            x = y;
        }

        if (schimb <= 2)
            Console.WriteLine("Secventa bitonica rotita");
        else
            Console.WriteLine("Nu este secventa bitonica rotita");
    }
}
