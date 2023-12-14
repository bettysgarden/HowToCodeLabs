// Класс, реализующий интерфейс ICheckInOut

namespace Roght_ISP;

public class Library : ICheckInOut
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