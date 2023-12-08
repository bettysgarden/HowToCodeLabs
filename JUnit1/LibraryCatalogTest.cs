using NUnit.Framework.Internal;

namespace Junit1;

import org.junit.Test;
import static org.junit.Assert.*;
import java.util.ArrayList;
import java.util.List;

public class LibraryCatalogTest {

    @Test
    public void testAddItem() {
        // Создаем объекты для тестирования
        Book book = new Book("The Hobbit", "J.R.R. Tolkien");
        Audiobook audiobook = new Audiobook("1984", "George Orwell", "John Smith");

        // Создаем каталог и добавляем элементы
        LibraryCatalog catalog = new LibraryCatalog();
        catalog.AddItem(book);
        catalog.AddItem(audiobook);

        // Проверяем, что элементы были добавлены
        List<ILibraryItem> expectedItems = new ArrayList<>();
        expectedItems.add(book);
        expectedItems.add(audiobook);

        assertEquals(expectedItems, catalog.getItems());
    }

    @Test
    public void testRemoveItem() {
        // Создаем объект для тестирования
        Book book = new Book("To Kill a Mockingbird", "Harper Lee");

        // Создаем каталог и добавляем книгу
        LibraryCatalog catalog = new LibraryCatalog();
        catalog.AddItem(book);

        // Удаляем книгу из каталога
        catalog.RemoveItem(book);

        // Проверяем, что книга была удалена
        assertTrue(catalog.getItems().isEmpty());
    }

    @Test
    public void testPrintCatalog() {
        // Создаем объекты для тестирования
        Book book = new Book("The Catcher in the Rye", "J.D. Salinger");
        Audiobook audiobook = new Audiobook("Pride and Prejudice", "Jane Austen", "Emma Thompson");

        // Создаем каталог и добавляем элементы
        LibraryCatalog catalog = new LibraryCatalog();
        catalog.AddItem(book);
        catalog.AddItem(audiobook);

        // Создаем ожидаемый вывод
        String expectedOutput = "Library Catalog:\nTitle: The Catcher in the Rye, Author: J.D. Salinger\nTitle: Pride and Prejudice, Author: Jane Austen, Narrator: Emma Thompson\n";

        // Перенаправляем вывод консоли для теста
        ByteArrayOutputStream outputStream = new ByteArrayOutputStream();
        System.setOut(new PrintStream(outputStream));

        // Вызываем метод для вывода каталога
        catalog.PrintCatalog();

        // Сравниваем ожидаемый вывод с фактическим
        assertEquals(expectedOutput, outputStream.toString());
    }
}

