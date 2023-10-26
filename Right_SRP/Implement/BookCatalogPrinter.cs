namespace Right_SRP;

class BookCatalogPrinter : IBookCatalogPrinter
{
    public void PrintCatalog(List<Book> books)
    {
        foreach (var book in books)
        {
            Console.WriteLine($"{book.Title} by {book.Author}");
        }
    }
}