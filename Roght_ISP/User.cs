// Класс, использующий интерфейсы ICheckInOut и IReservation
class User
{
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
