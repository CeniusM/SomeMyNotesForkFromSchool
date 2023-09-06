public class BookFileIO : IBookSerializer
{
    private string GetRoot()
    {
        return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MyCoolBooks";
    }

    private void CheckRootFolder()
    {
        string root = GetRoot();
        if (!Directory.Exists(root))
            Directory.CreateDirectory(root);
    }

    private Book DeserializeFile(string path)
    {
        string file = File.ReadAllText(path);
        string header = file.Split("\0")[0];
        string book = file.Split("\0")[0];

        int a  = 2; // 32bits (float)
        long b = 2; // 64bits (double)
        decimal c = 3; // 128buts

        return new Book("", new Chapter[0]);
    }    

    public Book LoadBook(string bookTitle)
    {
        CheckRootFolder();
        string path = GetRoot() + "\\" + bookTitle;
        if (!File.Exists(path))
            throw new Exception($"Could not find file \"{path}\"");

        return DeserializeFile(path);
    }

    public void SaveBook(Book book)
    {
        throw new Exception();
    }
}
