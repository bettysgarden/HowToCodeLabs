using Roght_ISP;

[TestClass]
public class UserManagerTest
{
    private UserManager userManager;

    [TestInitialize]
    public void TestInitialize()
    {
        userManager = new UserManager();
    }

    [TestMethod]
    public void TestAddUser_SuccessfulAddition()
    {
        // Arrange
        string email = "Pnku@example.com";
        string password = "SecureP@sswo54rd";

        // Act
        userManager.AddUser("John Doe", email, password);

        // Assert
        Assert.IsTrue(userManager.Users.Any(user => user.Email == email));
    }

    [TestMethod]
    public void TestAddUser_DuplicateEmail()
    {
        // Arrange
        string existingEmail = "Mila@example.com";
        string password = "SecureP@sswo54rd";
        int initialCount = userManager.Users.Count;

        // Act
        userManager.AddUser("Mila", existingEmail, password);

        // Assert
        Assert.AreEqual(initialCount, userManager.Users.Count);
    }

    [TestMethod]
    public void TestAddUser_InvalidEmail()
    {
        // Arrange
        string invalidEmail = "invalid.email";
        string password = "BobPass123";
        int initialCount = userManager.Users.Count;

        // Act
        userManager.AddUser("Bob Johnson", invalidEmail, password);

        // Assert
        Assert.IsFalse(userManager.Users.Any(user => user.Email == invalidEmail));
    }

    [TestMethod]
    public void TestAddUser_InvalidPassword()
    {
        // Arrange
        string email = "eva@example.com";
        string weakPassword = "weak";
        int initialCount = userManager.Users.Count;

        // Act
        userManager.AddUser("Eva Mugler", email, weakPassword);

        // Assert
        Assert.AreEqual(initialCount, userManager.Users.Count);
    }

    [TestMethod]
    public void TestEmailIsNotNull()
    {
        // Arrange
        int initialUserCount = userManager.Users.Count;

        // Act
        userManager.AddUser("Eva Mugler", null, "weak");

        // Assert
        Assert.AreEqual(initialUserCount, userManager.Users.Count);
    }
}
