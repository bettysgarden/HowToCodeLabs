// Класс для формирования отчетов
public class ReportProcessor
{
    public void GenerateReport(IReportGenerator reportGenerator, List<Book> books)
    {
        reportGenerator.GenerateReport(books);
    }
}
