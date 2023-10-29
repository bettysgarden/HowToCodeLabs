namespace HardcodingRight;

public interface ILibrary
{
    void AddBook(IItem book);
    void RemoveBook(IItem book);
    List<IItem> GetBooks();

    void SetBookAvailability(IItem book, bool available);
    bool IsBookAvailable(IItem book);

}