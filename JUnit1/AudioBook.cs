namespace Junit1;

// Реализация интерфейса ILibraryItem для аудиокниги.
public class Audiobook : ILibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Narrator { get; set; }

    public Audiobook(string title, string author, string narrator)
    {
        Title = title;
        Author = author;
        Narrator = narrator;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Narrator: {Narrator}");
    }
}