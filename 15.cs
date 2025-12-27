using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        bool cresc = true;
        bool bitonica = true;

        for (int i = 1; i < n; i++)
        {
            int y = int.Parse(Console.ReadLine());
            if (cresc)
            {
                if (y < x)
                {
                    cresc = false;
                }
            }
            else
            {
                if (y > x)
                {
                    bitonica = false;
                }
            }
            x = y;
        }

        if (!cresc && bitonica)
        {
            Console.WriteLine("Secventa este bitonica");
        }
        else
        {
            Console.WriteLine("Secventa nu este bitonica");
        }
    }
}
