namespace The_Library;

class Program
{
    static void Main(string[] args)
    {
        Fiction fiction = new();
        NonFiction nonFiction = new();
        LoadManager loadManager = new();
        if (File.Exists("fiction.txt"))
        {
            loadManager.LoadFile("fiction.txt", fiction);
        }

        if (File.Exists("nonFiction.txt"))
        {
            loadManager.LoadFile("nonFiction.txt", nonFiction);
        }
        SaveManager saveManager = new();
        saveManager.SaveFile(fiction, "fiction.txt");
        saveManager.SaveFile(nonFiction, "nonFiction.txt");
        Menu menu = new(fiction, nonFiction);

        
    }
}