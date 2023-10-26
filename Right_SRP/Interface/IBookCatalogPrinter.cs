namespace Right_SRP;

// Интерфейс для вывода каталога книг
public interface IBookCatalogPrinter
{
    // Вывод каталога книг на экран
    // может быть в файл или на экран (печатное/веб-представление)
    void PrintCatalog(List<Book> books);  
}