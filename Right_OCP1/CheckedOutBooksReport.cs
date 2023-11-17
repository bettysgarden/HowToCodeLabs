// Класс для подсчета выданных книг
public class CheckedOutBooksReport : IReportGenerator
{
    public void GenerateReport(List<Book> books)
    {
        int totalCheckedOutBooks = 0;
        foreach (var book in books)
        {
            if (book.IsCheckedOut)
            {
                totalCheckedOutBooks++;
            }
        }

        Console.WriteLine($"Всего выдано книг: {totalCheckedOutBooks}");
    }
}
