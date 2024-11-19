﻿namespace The_Library;

class Program
{
    static void Main(string[] args)
    {
        Fiction fiction = new();
        NonFiction nonFiction = new();
        
        Menu menu = new(fiction, nonFiction);
        menu.Running();
        
        SaveManager saveManager = new();
        saveManager.SaveFile(fiction, "fiction.txt");
        saveManager.SaveFile(nonFiction, "nonFiciton.txt");
    }
}