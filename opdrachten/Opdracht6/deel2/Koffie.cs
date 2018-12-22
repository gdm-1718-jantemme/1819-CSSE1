using System;
using System.Collections.Generic;

namespace deel2
{
    
    public class Koffie 
    {
        private List<string> _recept = new List<string>();
    
        public void Add(string ingredient)
        {
        _recept.Add(ingredient);
        }
    
        public void Show()
        {
        Console.WriteLine("\nRecept -------");
        foreach (string ingredient in _recept)
            Console.WriteLine(ingredient);
        }
    }
}