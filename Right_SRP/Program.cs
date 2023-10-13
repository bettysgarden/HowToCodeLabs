using Right_SRP;

class Program
{
    static void Main()
    {
        Library library = new Library();
        CatalogPrinter catalogPrinter = new CatalogPrinter();

        Book book1 = new Book
        {
            Title = "Book 1",
            Author = "Author 1",
            Pages = 200,
            IsAvailable = true
        };

        library.AddBook(book1);
        library.CheckOutBook(book1);

        catalogPrinter.PrintCatalog(library.Books);
    }
}