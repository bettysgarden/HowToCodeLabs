using Problem_OCP;

class Program
{
    static void Main(string[] args)
    {
        LibraryCatalog catalog = new LibraryCatalog();
        catalog.AddBook(new Book("The Catcher in the Rye", "J.D. Salinger"));
        catalog.AddBook(new Book("To Kill a Mockingbird", "Harper Lee"));

        // На данном этапе, чтобы добавить поддержку аудиокниг, потребуется изменить код класса LibraryCatalog,
        // что нарушает принцип OCP.
        
        //catalog.AddAudiobook(new Audiobook("The Great Gatsby", "F. Scott Fitzgerald", "narrator"));

        catalog.PrintCatalog();
    }
}