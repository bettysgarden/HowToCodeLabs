namespace Problem_LSP;

// Класс для аудиокниги
public class AudioBook : Book
{
    public override void Read()
    {
        //AudioBook  вызывает исключение при вызове метода Read. 
        throw new InvalidOperationException("No text to read.");
    }
    public void Play()
    {
        Console.WriteLine("Playing the audio-book.");
    }
}
