using System;

namespace lesweek3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string text;
            Console.WriteLine("Geef je naam in: ");
            text = Console.ReadLine();
            Console.WriteLine("Hallo " + text);*/

            // Rekenmachine
            int a, b;
            string bewerking;
            Console.WriteLine("Geef getal 1 in: ");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Geef getal 2 in: ");
            b = Int32.Parse(Console.ReadLine());

            int resultaat1 = optellen(a, b);
            int resultaat2 = delen(a, b);

            Console.WriteLine("Geef in welke bewerking je wilt uitvoeren (optelling, deling): ");
            bewerking = Console.ReadLine();

            if(bewerking == "optelling")
            {
                Console.WriteLine(resultaat1);
            }
            if(bewerking == "deling")
            {
                Console.WriteLine(resultaat2);
            }
        }
        static int optellen(int x, int y)
        {
            return x + y;
        }
        static int delen(int x, int y)
        {
            return x / y;
        }
    }
}
