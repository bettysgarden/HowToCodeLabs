namespace HardcodingRight;

public class Library
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

// Метод для добавления книги в библиотеку
    public void AddBook(Book book)
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

// Метод для удаления книги из библиотеки
    public void RemoveBook(Book book)
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

// Метод для получения списка всех книг в библиотеке
    public List<Book> GetBooks()
    {
        return new List<Book>(books);
    }
}