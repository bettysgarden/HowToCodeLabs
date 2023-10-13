namespace Problem_SRP;

public class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        // добавление книги в библиотеку
        books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        // удаление книги из библиотеки
        books.Remove(book);
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