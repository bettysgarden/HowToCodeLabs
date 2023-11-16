interface IBook
{
    void CheckOut(); // взять книгу
    void Return(); // вернуть книгу
    void PlaceHold(); // зарезервировать книгу
    void CalculateFine(); // рассчитать штраф
}
