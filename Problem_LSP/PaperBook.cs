namespace Problem_LSP;

// Класс, представляющий бумажную книгу
public class PaperBook : Book
{
    public override void Read()
    {
        Console.WriteLine("Чтение бумажной книги: " + Title);
    }
}