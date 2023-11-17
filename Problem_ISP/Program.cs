
class Program
{
    static void Main(string[] args)
    {
        Library book = new Library();
        User user = new User();
        user.ProcessBook(book); // Все методы из интерфейса вызываются, хотя не все нужны пользователю
    }
}
