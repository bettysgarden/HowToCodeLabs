// Класс, использующий интерфейсы ICheckInOut и IReservation

using System.Text.RegularExpressions;

public class User
{
    public String Name { get; }
    public String Email { get; }
    public String Password { get; }
    public User(String name, String email, String password)
    {
        this.Name = name;
        this.Email = email;
        this.Password = password;

    }
    // Метод для проверки корректности email
    public bool isValidEmail()
    {
        // Простая проверка наличия символа "@" в строке
        return Email != null && Email.Contains("@");
    }

    // Метод для проверки корректности пароля
    public bool IsValidPassword()
    {
        // Пароль должен содержать минимум 8 символов, одну заглавную букву, одну цифру и один специальный символ
        string passwordRegex = "^(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$";
        Regex regex = new Regex(passwordRegex);

        return regex.IsMatch(Password);
    }
    public void ProcessBook(ICheckInOut book)
    {
        book.CheckOut();
        book.Return();
    }

    public void ReserveBook(IReservation book)
    {
        book.PlaceHold();
    }
}
