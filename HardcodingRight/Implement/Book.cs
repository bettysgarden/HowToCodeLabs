namespace HardcodingRight;

public class Book : IItem
{
    public string Title { get; }
    public string Author { get; }
    private bool Availability = true; // По умолчанию книга доступна

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}
