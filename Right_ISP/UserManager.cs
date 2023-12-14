namespace Roght_ISP;

public class UserManager
{
    public readonly List<User> Users = new List<User>();

    // Метод для добавления пользователя
    public void AddUser(string name, string email, string password)
    {
        // Проверка уникальности email
        if (Users.Exists(u => u.Email == email))
        {
            Console.WriteLine("Пользователь с таким email уже существует.");
            return;
        }

        // Создание нового пользователя
        User newUser = new User(name, email, password);

        // Проверка корректности email и пароля
        if (newUser.isValidEmail() && newUser.IsValidPassword())
        {
            Users.Add(newUser);
            Console.WriteLine("Пользователь успешно добавлен.");
        }
        else
        {
            Console.WriteLine("Некорректный email или пароль.");
        }
    }
    // Метод для очистки списка пользователей
    public void ClearUsers()
    {
        Users.Clear();
    }
}