namespace HardcodingProblematic;
public class Library
{
    private List<Book> books = new();

    // Плохая читабельность

    // Жесткость
    // использование классов напрямую без интерфейсов
    public void Add(Book book)
    {
        books.Add(book);
    }

    // Жесткость
    // использование классов напрямую без интерфейсов
    public void Remove(Book book)
    {
        books.Remove(book);
    }

    public List<Book> GetBooks()
    {
        return books;
    }
}