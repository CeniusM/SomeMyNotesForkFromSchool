public interface IBookSerializer
{
    public Book LoadBook(string bookTitle);
    public void SaveBook(Book book);
}
