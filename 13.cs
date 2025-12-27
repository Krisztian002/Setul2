using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int schimbari = 0;
        int curent = int.Parse(Console.ReadLine());
        int primul = curent;

        for (int i = 1; i < n; i++)
        {
            int urmator = int.Parse(Console.ReadLine());
            if (urmator < curent)
            {
                schimbari++;
            }
            curent = urmator;
        }

        if (schimbari <= 1 && primul >= curent)
            Console.WriteLine("DA");
        else
            Console.WriteLine("NU");
    }
}
