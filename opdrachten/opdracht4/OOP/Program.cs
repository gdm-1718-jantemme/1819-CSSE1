using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public class Product
        {
            string naam, type;
            string[] ingediënten;
            public Product(string naam, string type, string[] ingediënten)
            {
                this.naam = naam;
                this.type = type;
                this.ingediënten = ingediënten;
            }
        }
        public class Prijs
        {
            string valuta;
            decimal bedrag;
            public Prijs(string valuta, decimal bedrag)
            {
                this.valuta = valuta;
                this.bedrag = bedrag;
            }
        }

        public class MenuItems: Product, Prijs
        {
            
        }
    }
}
