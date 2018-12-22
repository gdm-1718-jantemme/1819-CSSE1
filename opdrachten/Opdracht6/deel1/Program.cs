using System;

namespace opdracht6
{
    class Program
    {
        static void Main(string[] args)
        {
            VormFactory vormFactory = new VormFactory();
            IVorm vormA = vormFactory.GetVorm("cirkel");
            vormA.Teken();
        }
    }
}
