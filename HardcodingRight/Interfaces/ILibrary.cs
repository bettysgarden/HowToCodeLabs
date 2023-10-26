namespace HardcodingRight;

public interface ILibrary
{
    void AddBook(IBook book);
    void RemoveBook(IBook book);
    List<IBook> GetBooks();
}