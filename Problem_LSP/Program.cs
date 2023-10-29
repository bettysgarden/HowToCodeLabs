using Problem_LSP;

class Program
{
    static void Main(string[] args)
    {
        // Создаем экземпляр бумажной книги
        Book paperBook = new PaperBook();
        paperBook.Title = "Война и мир";

        // Создаем экземпляр аудиокниги
        Book audiobook = new Audiobook();
        audiobook.Title = "Алиса в Стране Чудес";

        Reader reader = new Reader();

        // Передаем бумажную книгу читателю
        reader.ReadBook(paperBook);

        // Передаем аудиокнигу читателю
        reader.ReadBook(audiobook); // Ошибка: Проигрывание аудиокниги, но выводится неверное название "Война и мир"
    }
}