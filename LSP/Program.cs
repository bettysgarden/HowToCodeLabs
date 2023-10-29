using LSP;

class Program
{
    static void Main(string[] args)
    {
        // Создаем экземпляр бумажной книги
        IBook paperBook = new PaperBook();
        paperBook.Title = "Война и мир";

        // Создаем экземпляр аудиокниги
        IBook audiobook = new Audiobook();
        audiobook.Title = "Алиса в Стране Чудес";
        //audiobook.

        Reader reader = new Reader();

        // Передаем бумажную книгу читателю
        reader.ReadBook(paperBook);

        // Передаем аудиокнигу читателю
        reader.ReadBook(audiobook); // Теперь корректно проигрывает аудиокнигу и выводит правильное название
    }
}