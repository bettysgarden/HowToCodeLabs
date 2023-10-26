using System;
using System.Collections.Generic;
using HardcodingProblematic;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        Book book1 = new Book("Зима тревоги нашей", "Джон Стейнбек");
        library.Add(book1);

        Book book2 = new Book("Убить пересмешника", "Харпер Ли");
        library.Add(book2);

        List<Book> books = library.GetBooks();

        Console.WriteLine("Books in the library:");
        foreach (Book book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
        }
    }
}