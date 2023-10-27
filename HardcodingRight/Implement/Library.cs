namespace HardcodingRight;

public class Library : ILibrary
{
    private List<IBook> books;

    public Library()
    {
        books = new List<IBook>();
    }

    public void AddBook(IBook book)
    {
        if (book != null)
        {
            books.Add(book);
        }
        else
        {
            throw new ArgumentNullException("Попытка добавить нулевую книгу в библиотеку");
        }
    }

    public void RemoveBook(IBook book)
    {
        if (books.Contains(book))
        {
            books.Remove(book);
        }
        else
        {
            throw new ArgumentException("Книга не найдена в библиотеке");
        }
    }

    public List<Book> GetBooks()
    {
        return new List<Book>(books);
    }

    public void SetBookAvailability(Book book, bool available)
    {
        book.SetAvailability(available);
    }

    public bool IsBookAvailable(Book book)
    {
        return book.IsAvailable();
    }
}
