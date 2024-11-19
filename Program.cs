namespace The_Library;

class Program
{
    static void Main(string[] args)
    {
        string fictionFile = "fiction.txt";
        string nonfictionFile = "nonFiction.txt";
        Fiction fiction = new();
        NonFiction nonFiction = new();
        LoadManager loadManager = new();
        if (File.Exists(fictionFile))
        {
            loadManager.LoadFile(fictionFile, fiction);
        }

        if (File.Exists(nonfictionFile))
        {
            loadManager.LoadFile(nonfictionFile, nonFiction);
        }
        SaveManager saveManager = new();
        saveManager.SaveFile(fiction, fictionFile);
        saveManager.SaveFile(nonFiction, nonfictionFile);
        Menu menu = new(fiction, nonFiction);

        
    }
}