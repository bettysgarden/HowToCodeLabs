namespace Right_SRP;

public class CatalogPrinter
{
    public void PrintCatalog(List<Book> books)
    {
        // Логика вывода списка книг
        foreach (var book in books)
        {
            Console.WriteLine($"{book.Title} by {book.Author}");
        }
    }
}