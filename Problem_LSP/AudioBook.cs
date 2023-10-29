namespace Problem_LSP;

// Класс, представляющий аудиокнигу
public class Audiobook : Book
{
    public override void Read()
    {
        Console.WriteLine("Проигрывание аудиокниги: " + Title);
    }
}