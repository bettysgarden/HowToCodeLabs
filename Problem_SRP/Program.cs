using System;
using System.Collections.Generic;
using Problem_SRP;


class Program
{
    static void Main()
    {
        Library library = new Library();

        Book book1 = new Book
        {
            Title = "Book 1",
            Author = "Author 1",
            Pages = 200,
            IsAvailable = true
        };

        library.AddBook(book1);
        library.CheckOutBook(book1);
        library.PrintCatalog();
    }
}