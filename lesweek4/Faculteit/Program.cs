using System;

namespace Faculteit
{
    class Program
    {
        static void Main(string[] args)
        {
            string b;
            long a = 1;

            Console.WriteLine("Geef het getal waarvan je de faculteit wil berekenen: ");
            b = Console.ReadLine();

            for(int i = 0; i <= Convert.ToInt16(b); i++)
            {
                a = a * i;
                if(a == 0)
                    a = 1;
            }
            if(a >= 0)
                Console.WriteLine("De faculteit van " + b + " is " + a);
            else
                Console.WriteLine("De faculteit van het opgegeven getal is te groot.");
        }
    }
}
