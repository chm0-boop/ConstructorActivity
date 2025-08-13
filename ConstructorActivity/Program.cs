using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Book 1: Default Constructor");
        Book book1 = new Book();
        book1.DisplayBookInfo();

        Console.WriteLine("\nBook 2: Basic Constructor");
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");
        book2.DisplayBookInfo();

        Console.WriteLine("\nBook 3: Detailed Constructor");
        Book book3 = new Book("1984", "George Orwell", 1949);
        book3.DisplayBookInfo();

        Console.WriteLine("\nBook 4: Complete Constructor");
        Book book4 = new Book("The Hobbit", "J.R.R. Tolkien", 1937, "Fantasy");
        book4.DisplayBookInfo();
    }
}