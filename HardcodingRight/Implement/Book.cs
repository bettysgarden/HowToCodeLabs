namespace HardcodingRight;

public class Book : IItem
{
    public string Title { get; }
    public string Author { get; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
        
    public void Display()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}");
    }
}
