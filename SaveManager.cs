using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Library
{
    public class SaveManager
    {
        
        public List<string> _savedBooks = new();
        public string _saveFile = "saveFile.txt";


        public void SaveFile(Shelf shelf)
        {
            foreach (Book book in shelf.Books)
            {
                _savedBooks.Add($"{book.Title};{book.Author};{book.Publisher}");
                
                
            }

            File.WriteAllLines("saveFile.txt", _savedBooks);
            
            foreach (string book in _savedBooks)
            {
                Console.WriteLine(book);
            }
        }
    
        
    
    }     
}
