using System;

namespace Faculteit
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = 1;
            for(int i = 0; i <= 20; i++)
            {
                a = a * i;
                if(a == 0)
                    a = 1;
                Console.WriteLine(a);
            }
        }
    }
}
