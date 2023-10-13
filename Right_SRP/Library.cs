namespace Right_SRP;

public class Library
{
    private List<Book> books = new List<Book>();
    public List<Book> Books
    {
        get { return books; }
    }
    public void AddBook(Book book)
    {
        // Логика добавления книги в библиотеку
        books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        // Логика удаления книги из библиотеки
        books.Remove(book);
    }

    public void CheckOutBook(Book book)
    {
        // Логика выдачи книги читателю
        book.IsAvailable = false;
    }

    public void ReturnBook(Book book)
    {
        // Логика возврата книги в библиотеку
        book.IsAvailable = true;
    }
}