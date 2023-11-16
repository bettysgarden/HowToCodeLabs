// Класс книги
public class Book
{
    public string Title { get; set; }
    public bool IsCheckedOut { get; set; }
    // ... другие свойства книги

    public void Checkout()
    {
        if (!IsCheckedOut)
        {
            IsCheckedOut = true;
        }
        else
        {
            throw new InvalidOperationException("Книга уже выдана");
        }
    }

    public void Return()
    {
        IsCheckedOut = false;
    }
}
