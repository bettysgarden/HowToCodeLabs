using System;
using System.Collections.Generic;
using HardcodingRight;


class Program
{
    static void Main(string[] args)
    {
        ILibrary library = new Library();

        IBook book1 = new Book("Зима тревоги нашей", "Джон Стейнбек");
        library.AddBook(book1);

        IBook book2 = new Book("Убить пересмешника", "Харпер Ли");
        library.AddBook(book2);

        List<IBook> books = library.GetBooks();

        Console.WriteLine("Books in the library:");
        foreach (IBook book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
        }
    }
}