using System;

namespace Faculteit
{
    class Program
    {
        static void Main(string[] args)
        {
            string getal;

            Console.WriteLine("Geef het getal waarvan je de faculteit wil berekenen: ");
            getal = Console.ReadLine();

            BerekenFaculteit(getal);
        }

        public static void BerekenFaculteit(string opgegevenGetal)
            {
                long faculteit = 1;
                for(int i = 0; i <= Convert.ToInt16(opgegevenGetal); i++)
                {
                    faculteit = faculteit * i;
                    if(faculteit == 0)
                        faculteit = 1;
                }
                if(faculteit >= 0)
                    Console.WriteLine("De faculteit van " + opgegevenGetal + " is " + faculteit);
                else
                    Console.WriteLine("De faculteit van het opgegeven getal is te groot.");
            }
    }
}
