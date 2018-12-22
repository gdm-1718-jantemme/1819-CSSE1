using System;

namespace deel1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author("Jan", "jan@gmail.com", 'M');
            Book book = new Book("Boeknaam", author, 10, 2);
        }
    }
}