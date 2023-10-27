namespace HardcodingProblematic;

public class Library
{
    private List<Book> books = new();

    public void Add(Book book)
    {
        books.Add(book);
    }

    public List<Book> GetBooks()
    {
        return books;
    }

    public bool IsBookAvailable(Book book, bool check1, bool check2, bool check3)
    {
        bool isAvailable = books.Contains(book);
        if (check1)
        {
            isAvailable = !isAvailable;
        }
        if (check2)
        {
            isAvailable = !isAvailable;
        }
        if (check3)
        {
            isAvailable = !isAvailable;
        }
        return isAvailable;
    }
}
