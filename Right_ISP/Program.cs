class Program
{
    static void Main(string[] args)
    {
        Library book = new Library();
        User user = new User();

        user.ProcessBook(book); // Используется только ICheckInOut
        // user.ReserveBook(book); // Если нужно использовать резервирование, можно добавить соответствующий объект

        // Методы, не используемые User, не приводят к избыточности или ошибкам
    }
}
