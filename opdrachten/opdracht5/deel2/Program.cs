using System;

namespace deel2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon p1 = new Persoon();
            Student s1 = new Student();
            Console.WriteLine(s1.GenereerWachtwoord());
        }
    }
}
