// Класс для формирования отчета
// Если мы захотим добавить другие аспекты отчета, нам придется изменять этот класс.
public class ReportGenerator
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
