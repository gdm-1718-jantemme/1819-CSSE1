using System;

namespace Tafels
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
