namespace Tests;

[TestClass]
public class UserTests
{
    [TestMethod]
    public void TestIsValidEmail_ValidEmail_ReturnsTrue()
    {
        User user = new User("John Doe", "johnexamp@le.com", "SecurePs%sword");
        Assert.IsTrue(user.isValidEmail());
    }
    [TestMethod]
    public void TestIsValidPassword_ValidPassword_ReturnsTrue()
    {
        User user = new User("Bob Johnson", "bob@example.com", "StrongP&ss123");
        Assert.IsTrue(user.IsValidPassword());
    }


}