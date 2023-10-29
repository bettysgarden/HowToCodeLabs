namespace Problem_LSP;

// Абстрактный класс, представляющий книгу в библиотеке
public abstract class Book
{
    public string Title { get; set; }

    public abstract void Read();
}