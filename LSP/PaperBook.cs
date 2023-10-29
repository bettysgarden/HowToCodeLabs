namespace LSP;

// Класс, представляющий бумажную книгу
public class PaperBook : IBook
{
    public string Title { get; set; }

    public void Read()
    {
        Console.WriteLine("Чтение бумажной книги: " + Title);
    }
}