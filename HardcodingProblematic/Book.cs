namespace HardcodingProblematic;

public class Book
{
    // Жесткость: отсутствие интерфейса
        // Например: аудиокниги
    public string Title { get; }
    public string Author { get; }
    private Library library; // Нарушение связности: Класс Book имеет прямую ссылку на Library.

    public Book(string title, string author, Library library)
    {
        Title = title;
        Author = author;
        this.library = library;
    }

    // неожиданное поведение -- книга сама добавляет себя в библиотеку
    public void AddToLibrary(Book book) 
    {
        library.Add(book);
    }
}

