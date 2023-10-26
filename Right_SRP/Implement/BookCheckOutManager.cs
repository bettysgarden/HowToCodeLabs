namespace Right_SRP;
class BookCheckoutManager : IBookCheckoutManager
{
    public void CheckOutBook(Book book)
    {
        if (book.IsAvailable)
        {
            book.IsAvailable = false;
        }
        else
        {
            Console.WriteLine("This book is already checked out.");
        }
    }

    public void ReturnBook(Book book)
    {
        if (!book.IsAvailable)
        {
            book.IsAvailable = true;
        }
        else
        {
            Console.WriteLine("This book is already available.");
        }
    }
}