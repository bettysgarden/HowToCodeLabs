namespace Roght_ISP.Tests;

using NUnit.Framework;
using System.Linq;

[TestFixture]
public class UserManagerTest
{
    [Test]
    // лист сущест
    // email is not null
    public void TestAddUser_SuccessfulAddition()
    {

        UserManager userManager = new UserManager();

        userManager.AddUser("John Doe", "Pnku@example.com", "SecureP@sswo54rd");

        Assert.IsTrue(userManager.Users.Any(user => user.Email == "Pnku@example.com"));

    }

    [Test]
    public void TestAddUser_DuplicateEmail()
    {

        UserManager userManager = new UserManager();
        int count = userManager.Users.Count();

        userManager.AddUser("Mila", "Mila@example.com", "SecureP@sswo54rd");

        // Assert
        Assert.AreEqual(count, userManager.Users.Count); // Новый пользователь не добавлен
    }

    [Test]
    public void TestAddUser_InvalidEmail()
    {

        UserManager userManager = new UserManager();


        userManager.AddUser("Bob Johnson", "invalid.email", "BobPass123");


        // Assert
        Assert.IsFalse(userManager.Users.Any(user => user.Email == "invalid.email"));
        // Пользователь не добавлен из-за некорректного email
    }

    [Test]
    public void TestAddUser_InvalidPassword()
    {

        UserManager userManager = new UserManager();
        int count = userManager.Users.Count();

        userManager.AddUser("Eva Mugler", "eva@example.com", "weak");

        // Assert

        Assert.AreEqual(count, userManager.Users.Count); // Пользователь не добавлен из-за некорректного пароля
    }

    [Test]
    public void TestEmailIsNotNull()
    {
        UserManager userManager = new UserManager();
        int initialUserCount = userManager.Users.Count;

        // Act
        userManager.AddUser("Eva Mugler", null, "weak");

        // Assert
        Assert.AreEqual(initialUserCount, userManager.Users.Count);

    }
}
