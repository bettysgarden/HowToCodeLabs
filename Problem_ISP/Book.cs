// Базовый класс для книги в библиотеке
public class Book : IReadable
{
    public virtual string Read()
    {
        return "Чтение книги";
    }
}
