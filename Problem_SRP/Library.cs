namespace Problem_SRP;

// управление книгами (добавление, удаление, выдача и возврат)
// вывод каталога книг на экран
public class Library
{
    private List<Book> books = new List<Book>();
    // save sorted
    public void AddBook(Book book)
    {
        // добавление книги в библиотеку
        books.Add(book);
    }
    public void CheckOutBook(Book book)
    {
        // выдача книги читателю
        book.IsAvailable = false;
    }

    public void ReturnBook(Book book)
    {
        // возврат книги в библиотеку
        book.IsAvailable = true;
    }

    public void PrintCatalog()
    {
        // вывод списка книг
        foreach (var book in books)
        {
            Console.WriteLine($"{book.Title} by {book.Author}");
        }
    }
}