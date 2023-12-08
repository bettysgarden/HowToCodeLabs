namespace LSP;

// Класс, представляющий читателя
public class Reader
{
    public void ReadBook(IReadable book)
    {
        book.Read();
    }
}