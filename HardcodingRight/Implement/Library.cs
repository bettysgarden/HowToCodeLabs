namespace HardcodingRight;

public class Library : ILibrary
{
    private List<IItem> books;
    private Dictionary<IItem, bool> bookAvailability;

    public Library()
    {
        books = new List<IItem>();
        bookAvailability = new Dictionary<IItem, bool>();
    }

    public void AddBook(IItem book)
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

    public void SetBookAvailability(IItem book, bool available)
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

    public bool IsBookAvailable(IItem book)
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
        return new List<IItem>(books);
    }
}
