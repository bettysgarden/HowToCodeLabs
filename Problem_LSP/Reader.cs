namespace Problem_LSP;

// Класс, представляющий читателя
public class Reader
{
    public void ReadBook(Book book)
    {
        Console.WriteLine(book.Read());
    }
}
