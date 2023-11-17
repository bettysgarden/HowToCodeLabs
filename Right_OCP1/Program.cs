class Program
{
    static void Main(string[] args)
    {
        List<Book> libraryBooks = new List<Book>
        {
            new Book { Title = "Book 1", IsCheckedOut = true },
            new Book { Title = "Book 2", IsCheckedOut = false },
            new Book { Title = "Book 3", IsCheckedOut = true }
        };

        ReportProcessor reportProcessor = new ReportProcessor();

        // Формирование отчета о выданных книгах
        IReportGenerator checkedOutBooksReport = new CheckedOutBooksReport();
        reportProcessor.GenerateReport(checkedOutBooksReport, libraryBooks);

        // Формирование отчета о задолженностях
        IReportGenerator overdueBooksReport = new OverdueBooksReport();
        reportProcessor.GenerateReport(overdueBooksReport, libraryBooks);

        Console.ReadLine();
    }
}
