namespace Right_SRP;

class Library : ILibrary
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }

    public List<Book> GetAllBooks()
    {
        return books;
    }
}