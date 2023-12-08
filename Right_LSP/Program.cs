using LSP;

class Program
{
    static void Main(string[] args)
    {
        Reader reader = new Reader();
        
        // Создаём экземпляр аудиокниги
        IReadable audioBook = new AudioBook();

        // Передаём экземпляр аудиокниги функции, ожидая чтения книги
        
				// замена объекта Book на AudioBook не ведёт к изменению ожидаемого поведения программы
				reader.ReadBook(audioBook);

        Console.ReadLine();
    }
}
