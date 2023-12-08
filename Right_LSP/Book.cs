namespace LSP;

// Базовый класс для книги в библиотеке
public class Book : IReadable
{
    public virtual void Read()
    {
        Console.WriteLine("Чтение книги");
    }
}
