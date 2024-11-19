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
        
        Menu menu = new(fiction, nonFiction);
        menu.Running();
        
        SaveManager saveManager = new();
        saveManager.SaveFile(fiction, fictionFile);
        saveManager.SaveFile(nonFiction, nonfictionFile);
        

        
    }
}