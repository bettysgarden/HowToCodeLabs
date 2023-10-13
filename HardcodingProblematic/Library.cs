namespace HardcodingProblematic;

// Проблема 1: Жесткость (Rigidity)
// Добавление новых операций с книгами требует изменения класса Library
public class Library
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    // Проблема 3: Плохая читабельность (Low Readability)
    // "Add" - не является информативным именем для операции
    public void Add(Book book)
    {
        books.Add(book);
    }

    // Проблема 3: Плохая читабельность (Low Readability)
    // "Remove" - не является информативным именем для операции
    public void Remove(Book book)
    {
        books.Remove(book);
    }

    public List<Book> GetBooks()
    {
        return books;
    }
}