namespace HardcodingProblematic;

public class Book
{
    public string Title { get; }
    public string Author { get; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    // Ненужная повторяемость 
    // дублирование информации о книге
    public string GetTitle()
    {
        return Title;
    }

    // Ненужная повторяемость 
    // дублирование информации о книге
    public string GetAuthor()
    {
        return Author;
    }
}
