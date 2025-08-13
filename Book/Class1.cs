using System;

public class Book
{
    private string title;
    private string author;
    private int yearPublished;
    private string genre;

    public Book()
    {
        title = "Unknown";
        author = "Unknown";
        yearPublished = 0;
        genre = "Unknown";
    }

    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
        yearPublished = 0;
        genre = "Unknown";
    }

    public Book(string title, string author, int yearPublished)
    {
        this.title = title;
        this.author = author;
        this.yearPublished = yearPublished;
        genre = "Unknown";
    }

    public Book(string title, string author, int yearPublished, string genre)
    {
        this.title = title;
        this.author = author;
        this.yearPublished = yearPublished;
        this.genre = genre;
    }

    public void DisplayBookInfo()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Year Published: {yearPublished}");
        Console.WriteLine($"Genre: {genre}");
    }
}