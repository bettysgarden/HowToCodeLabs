using System;
using System.Collections.Generic;
using HardcodingProblematic;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
        library.Add(book1);

        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");
        library.Add(book2);

        List<Book> books = library.GetBooks();

        Console.WriteLine("Books in the library:");
        foreach (Book book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
        }
    }
}