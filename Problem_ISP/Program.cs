
class Program
{
    static void Main(string[] args)
    {
        Reader reader = new Reader();
        
        // Создаём экземпляр аудиокниги
        Book audioBook = new AudioBook();

        // Передаём экземпляр аудиокниги функции, ожидая чтения книги
        // Наследующий класс должен дополнять, а не замещать поведение базового класса.
				// при переопределении мы изменили поведение исходного класса
				// кого куда нельзя подставить?
				reader .ReadBook(audioBook);

        Console.ReadLine();
    }
}
