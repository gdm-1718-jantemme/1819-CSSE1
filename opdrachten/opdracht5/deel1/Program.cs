using System;

namespace opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author("Jan", "jan@gmail.com", 'M');
            Book book = new Book("Boeknaam", author, 10, 2);
        }
    }

    public class Author
    {
        private string name;
        private string email;
        private char gender;

        public Author(string name1, string email1, char gender1)
        {
            name = name1;
            email = email1;
            gender = gender1;
        }

        public string getName()
        {
            return name;
        }
    }

    public class Book
    {
        string name;
        Author author;
        double price;
        int qtyInStock = 0;

        public Book(string name1, Author author1, double price1, int qtyInStock1) {
            name = name1;
            author = author1;
            price = price1;
            qtyInStock = qtyInStock1;
        }

        public string getName() {
            return name;
        }

        public Author getAuthor() {
            return author;
        }

        public double getPrice() {
            return price;
        }

        public void setPrice(double price1) {
            price = price1;
        }

        public int getQtyInStock() {
            return qtyInStock;
        }

        public void setQtyInStock(int qtyInStock1) {
            qtyInStock = qtyInStock1;
        }

        public void print() {
            Console.WriteLine("Boek: "+name);
            Console.WriteLine("Auteur: "+author.getName());
        }

    }
}
