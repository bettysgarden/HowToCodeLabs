using Roght_ISP;

class Program
{
    static void Main(string[] args)
    {
        Library book = new Library();
        User user = new User("Liza", "Liza@gmailAQ.com", "SecureP@sswo54rd");

        user.ProcessBook(book);
    }
}
