using System;
using System.Collections.Generic;
using HardcodingProblematic;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        Book book1 = new Book("Зима тревоги нашей", "Джон Стейнбек", library);
        //library.Add(book1);
        book1.AddToLibrary(book1);

        Book book2 = new Book("Убить пересмешника", "Харпер Ли", library);
        //library.Add(book2);
        book2.AddToLibrary(book2);


 bool checkAvailability = true;
        if (checkAvailability)
        {
            bool isAvailable = CheckAvailabilityWithConfusion(library, book1);
            Console.WriteLine("Book 1 is available: " + isAvailable);

            isAvailable = CheckAvailabilityWithConfusion(library, book2);
            Console.WriteLine("Book 2 is available: " + isAvailable);
        }

        List<Book> books = library.GetBooks();

        Console.WriteLine("Books in the library:");
        foreach (Book book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
        }
    }
}
