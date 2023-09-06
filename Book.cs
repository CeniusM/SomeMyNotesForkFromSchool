public class Book
{
    public string Title;
    public Chapter[] Chapters;

    public Book(string title, Chapter[] chapters)
    {
        Title = title;
        Chapters = chapters;
    }
}