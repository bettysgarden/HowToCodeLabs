namespace Junit1
{
    public class Book : ILibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void Display()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}" + Environment.NewLine); // Include Environment.NewLine
        }
    }
}