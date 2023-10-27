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

        library.SetBookAvailability(book1, false); // Книгу 1 сделали недоступной через библиотеку
        library.SetBookAvailability(book2, true);  // Книгу 2 сделали доступной через библиотеку

        bool isAvailable = library.IsBookAvailable(book1);
        Console.WriteLine("Книга 1 доступнаe: " + isAvailable);

        isAvailable = library.IsBookAvailable(book2);
        Console.WriteLine("Книга 2 доступна: " + isAvailable);

        List<IBook> books = library.GetBooks();

        Console.WriteLine("Книги в библиотеке:");
        foreach (IBook book in books)
        {
            Console.WriteLine($"Название: {book.Title}, Автор: {book.Author}");
        }
    }
}
