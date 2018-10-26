using System;

namespace lesweek5
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = "Dit is een tekstje.";
            int lengte = tekst.Length;

            string deel = "";
            foreach(var word in tekst)
            {
                string word1 = tekst.Trim(' ');
                string.Concat(deel, word1);
            }
            Console.WriteLine(deel);
            Console.WriteLine("*******************************************************");

            for(int i = 0; i < lengte; i ++)
            {
                string karakter = tekst.Substring(i, 1);
                Console.WriteLine(karakter);
            }
            Console.WriteLine("*******************************************************");

            Console.WriteLine(tekst.ToLower());
            Console.WriteLine("*******************************************************");

            Console.WriteLine(tekst.ToUpper());
            Console.WriteLine("*******************************************************");
        }
    }
}
