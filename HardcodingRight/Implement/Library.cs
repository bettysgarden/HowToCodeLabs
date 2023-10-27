namespace HardcodingRight;

public class Library : ILibrary
{
    private List<IItem> books;
    private Dictionary<IItem, bool> bookAvailability;

    public Library()
    {
        books = new List<IBook>();
        bookAvailability = new Dictionary<IBook, bool>();
    }

    public void AddBook(IBook book)
    {
        if (book != null)
        {
            books.Add(book);
            bookAvailability[book] = true; // По умолчанию книга доступна
        }
        else
        {
            throw new ArgumentNullException("Попытка добавить нулевую книгу в библиотеку");
        }
    }

    public void SetBookAvailability(IBook book, bool available)
    {
        if (bookAvailability.ContainsKey(book))
        {
            bookAvailability[book] = available;
        }
        else
        {
            throw new ArgumentException("Книга не найдена в библиотеке");
        }
    }

    public bool IsBookAvailable(IBook book)
    {
        if (bookAvailability.ContainsKey(book))
        {
            return bookAvailability[book];
        }
        else
        {
            throw new ArgumentException("Книга не найдена в библиотеке");
        }
    }

    public List<IBook> GetBooks()
    {
        return new List<IBook>(books);
    }
}
