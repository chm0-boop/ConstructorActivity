Dela Cerna, Leachim C.
Verano, Kierstien S.

The Problem
Your task is to build a Book class for a simple library management system. Not all the books in the library have complete information available, so you need to design your class to handle these different scenarios.

Requirements:

Define the Book Class: Create a new class named Book with the following private fields to store information about a book:

string title

string author

int yearPublished

string genre

Implement Multiple Constructors: Your Book class must have the following four constructors. C# will automatically choose the correct one based on the number and type of arguments you provide when creating a new Book object.

Constructor 1 (Default): A parameterless constructor. It should initialize all string fields to "Unknown" and the integer field to 0. This is for books where no information is available yet.

Constructor 2 (Basic): A constructor that accepts only the title and author. It should initialize these two fields and use the default values for the remaining fields (yearPublished and genre).

Constructor 3 (Detailed): A constructor that accepts the title, author, and yearPublished. It should initialize these three fields and use the default value for the genre.

Constructor 4 (Complete): A constructor that accepts all four fields: title, author, yearPublished, and genre.

Create a DisplayBookInfo() Method: Add a public method to your Book class called DisplayBookInfo(). This method should neatly print all the details of the book to the console, similar to the format below:

Title: The Hobbit
Author: J.R.R. Tolkien
Year Published: 1937
Genre: Fantasy
Test Your Implementation: In your Main method (Program.cs), create at least one Book object using each of the four constructors. After creating each object, call the DisplayBookInfo() method to prove that each constructor successfully initialized the object with the correct data.

Example Main Method (for testing)
C#

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Book 1: Default Constructor ---");
        Book book1 = new Book();
        book1.DisplayBookInfo();

        Console.WriteLine("\n--- Book 2: Basic Constructor ---");
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");
        book2.DisplayBookInfo();

        // Add code to create Book 3 using the Detailed Constructor

        // Add code to create Book 4 using the Complete Constructor
    }
}
