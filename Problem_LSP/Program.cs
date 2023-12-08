
using Problem_LSP;

class Program
{
    static void Main(string[] args)
    {
        Reader reader = new Reader();
        Book audioBook = new AudioBook();

        Book book = new Book();
        //reader.ReadBook(book);

        reader.ReadBook(audioBook); // Нарушение принципа Liskov Substitution

        Console.ReadLine();
    }
}
