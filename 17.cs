using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int deschise = 0;
        int nivelMax = 0;
        bool corect = true;

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                deschise++;
                if (deschise > nivelMax) nivelMax = deschise;
            }
            else
            {
                if (deschise > 0) deschise--;
                else corect = false;
            }
        }

        if (corect && deschise == 0)
            Console.WriteLine($"Corecta, nivel maxim {nivelMax}");
        else
            Console.WriteLine("Incorecta");
    }
}
