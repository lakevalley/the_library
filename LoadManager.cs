namespace The_Library;

public class LoadManager
{
    public void LoadFile(string saveFile, Shelf shelf)
    {
        string[] books = File.ReadAllLines(saveFile);
        foreach (string line in books)
        {
            string[] book = line.Split(";");
            string title = book[0];
            string author = book[1];
            string publisher = book[2];
            shelf.Books.Add(new Book(title, author, publisher));
        }
    }
}