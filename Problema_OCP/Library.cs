class Library : IBook
{
    public void CheckOut()
    {
        Console.WriteLine("Книга была взята в библиотеке.");
    }

    public void Return()
    {
        Console.WriteLine("Книга была возвращена в библиотеку.");
    }

    public void PlaceHold()
    {
        Console.WriteLine("Книга была зарезервирована.");
    }

    public void CalculateFine()
    {
        Console.WriteLine("Подсчет штрафа за просрочку.");
    }
}
