// Класс, реализующий интерфейс ICheckInOut
class Library : ICheckInOut
{
    public void CheckOut()
    {
        Console.WriteLine("Книга была взята в библиотеке.");
    }

    public void Return()
    {
        Console.WriteLine("Книга была возвращена в библиотеку.");
    }
}
