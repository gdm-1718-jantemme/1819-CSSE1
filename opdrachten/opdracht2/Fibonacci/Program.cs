using System;

namespace lesweek4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 0;
            b = 1;
            for(int i = 0; i <= 20; i++)
            {
                if(i < 1)
                    c = 0;
                else
                    c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
        }
    }
}
