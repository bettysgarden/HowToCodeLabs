using Right_SRP;

class Program
{
    static void Main()
    {
        ILibrary library = new Library();
        IBookCatalogPrinter catalogPrinter = new BookCatalogPrinter();
        IBookCheckoutManager checkoutManager = new BookCheckoutManager();

        Book book1 = new Book
        {
            Title = "Book 1",
            Author = "Author 1",
            Pages = 200,
            IsAvailable = true
        };

        library.AddBook(book1);
        catalogPrinter.PrintCatalog(library.GetAllBooks());

        checkoutManager.CheckOutBook(book1);
        checkoutManager.ReturnBook(book1);
    }
}