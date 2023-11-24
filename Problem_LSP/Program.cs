using Problem_LSP;

class Program
{
    static void Main(string[] args)
    {
        Reader reader = new Reader();
        
        // Создаём экземпляр аудиокниги
        Book audioBook = new AudioBook();
        
        // оба метода возвращают сроку 
        // разное поведение должно быть, должно быть четкое различие
        

        // Передаём экземпляр аудиокниги функции, ожидая чтения книги
        // Наследующий класс должен дополнять, а не замещать поведение базового класса.
				// при переопределении мы изменили поведение исходного класса
        reader.ReadBook(audioBook);

        Console.ReadLine();
    }
}
