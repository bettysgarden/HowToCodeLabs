using NUnit.Framework.Legacy;

namespace Junit1;
[TestFixture]
public class LibraryCatalogTest
{
    [Test]
    public void AddItem_AddsItemToList()
    {
        // Arrange
        var catalog = new LibraryCatalog();
        var book = new Book("Test Book", "Test Author");

        // Act
        catalog.AddItem(book);

        // Assert
        CollectionAssert.Contains(catalog.GetItems(), book);
    }

    [Test]
    public void RemoveItem_RemovesItemFromList()
    {
        // Arrange
        var catalog = new LibraryCatalog();
        var book = new Book("Test Book", "Test Author");
        catalog.AddItem(book);

        // Act
        catalog.RemoveItem(book);

        // Assert
        CollectionAssert.DoesNotContain(catalog.GetItems(), book);
    }
}