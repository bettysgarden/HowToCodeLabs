namespace LSP;

// Интерфейс, представляющий книгу
public interface IBook
{
    string Title { get; set; }
    void Read();
}