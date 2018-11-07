using System;

namespace lesweek4
{
    class Program
    {
        static void Main(string[] args)
        {
            RijVanFibonacci();
        }

        public static void RijVanFibonacci()
        {
            int getal1, getal2, uitkomst;
            getal1 = 0;
            getal2 = 1;
            for(int i = 0; i <= 45; i++)
            {
                if(i < 1)
                    uitkomst = 0;
                else
                    uitkomst = getal1 + getal2;
                getal1 = getal2;
                getal2 = uitkomst;
                Console.WriteLine(uitkomst);
            }
        }
    }
}
