using System;

namespace Tafels
{
    class Program
    {
        static void Main(string[] args)
        {
            string getal;

            BerekenAlleTafels();

            Console.WriteLine("Geef een getal waarvan in: ");
            getal = Console.ReadLine();
            BerekenTafelVanGetal(getal);
        }

        public static void BerekenAlleTafels()
        {
            for(int i = 0; i <= 10; i++)
            {
                for(int a = 0; a <= 10; a++)
                {
                    Console.WriteLine(i + " * " + a + " = " + (i*a));
                }
                Console.WriteLine("\n");
            }
        }
    
        public static void BerekenTafelVanGetal(string grondgetal)
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + " * " + grondgetal + " = " + (i*Convert.ToInt16(grondgetal)));
            }
            Console.WriteLine("\n");
        }
    }

}
