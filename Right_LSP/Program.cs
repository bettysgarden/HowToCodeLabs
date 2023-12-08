using LSP;

class Program
{
    static void Main(string[] args)
    {
        Reader reader = new Reader();
        
        // Создаём экземпляр аудиокниги
        IReadable audioBook = new AudioBook();

        
				reader.ReadBook(audioBook);

        Console.ReadLine();
    }
}
