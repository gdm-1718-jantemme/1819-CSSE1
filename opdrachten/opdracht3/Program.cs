using System;

namespace opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] menu = new string[7,2] {
            {"plat water","1"},
            {"cola 25 cl","1,5"},
            {"cola 33 cl","2"},
            {"witte wijn","3"},
            {"pils","2"},
            {"toast","5"},
            {"kaasplank","4"}};

            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine(menu[i,0] + "\t: " + menu[i,1]);
            }

            // Om bij een multidimentionale array te kunnen sorteren zou je zelf een functie moeten schrijven. 

            Console.WriteLine("van welk product wil je de prijs weten?");
            string gevraagdeItem = Console.ReadLine();
            lookUpItem(menu, gevraagdeItem);
 
        }

        public static void lookUpItem(string [,] menu, string item)
        {
            for(int i = 0; i < 7; i++)
            {
                if(item == menu[i,0])
                {
                    Console.WriteLine("De prijs van dit item bedraagt " + menu[i, 1]);
                }
            }
        }
    }
}
