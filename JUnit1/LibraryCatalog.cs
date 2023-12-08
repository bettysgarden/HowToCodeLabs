// Класс LibraryCatalog остается закрытым для изменения, но открытым для расширения.

using Junit1;

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

    public List<ILibraryItem> GetItems()
    {
        return items;
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