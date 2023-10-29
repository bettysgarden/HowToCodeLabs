namespace LSP;

// Класс, представляющий аудиокнигу
public class Audiobook : IBook
{
    public string Title { get; set; }

    public void Read()
    {
        Console.WriteLine("Проигрывание аудиокниги: " + Title);
    }
}