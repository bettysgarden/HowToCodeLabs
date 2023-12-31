// Класс LibraryCatalog остается закрытым для изменения, но открытым для расширения.

using OCP;

public class LibraryCatalog
{
    private List<ILibraryItem> items = new List<ILibraryItem>();

    public void AddItem(ILibraryItem item)
    {
        items.Add(item);
    }

    public void RemoveItem(ILibraryItem item)
    {
        items.Remove(item);
    }

    public void PrintCatalog()
    {
        Console.WriteLine("Library Catalog:");
        foreach (var item in items)
        {
            item.Display(); // Вызываем метод Display для каждого элемента, который выводит информацию о нем.
        }
    }
}