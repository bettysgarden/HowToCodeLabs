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

        ReportGenerator reportGenerator = new ReportGenerator();
        reportGenerator.GenerateReport(libraryBooks);

        Console.ReadLine();
    }
}
