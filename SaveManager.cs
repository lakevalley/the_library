using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Library
{
    public class SaveManager
    {
        
        


        public void SaveFile(Shelf shelf, string saveFile)
        {
            List<string> _savedBooks = new();

                foreach (Book book in shelf.Books)
                {
                    _savedBooks.Add($"{book.Title};{book.Author};{book.Publisher}");
                
                }

                File.WriteAllLines(saveFile, _savedBooks);
            
                foreach (string book in _savedBooks)
                {
                    Console.WriteLine(book);
                }
        }
    
        
    
    }     
}
