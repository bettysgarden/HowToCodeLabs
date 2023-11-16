 // Другой класс для подсчета задолженностей
public class OverdueBooksReport : IReportGenerator
{
    public void GenerateReport(List<Book> books)
    {
        int totalOverdueBooks = 0;
        foreach (var book in books)
        {
            // Логика проверки на задолженность, например, по дате возврата
        }

        Console.WriteLine($"Всего задолженных книг: {totalOverdueBooks}");
    }
}
