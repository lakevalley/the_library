namespace The_Library;

public class Menu
{
    Fiction _fiction;
    NonFiction _nonFiction;

    public Menu(Fiction fiction, NonFiction nonFiction)
    {
        _fiction = fiction;
        _nonFiction = nonFiction; 
    }

    public void Running()
    {
        bool running = true;
        while (running)
        {
            PrintMenu();
            running = Interact();
        }
    }

    private void PrintMenu()
    {
        Console.WriteLine("Choose option");
        Console.WriteLine("1. Add a Fiction book");
        Console.WriteLine("2. Add a Non-Fiction book");
        Console.WriteLine("4. Search books from a author");
        Console.WriteLine("5. Search for a book title");
        Console.WriteLine("8. Show Non-Fiction books");
        Console.WriteLine("9. Show Fiction books");
        Console.WriteLine("0. Exit");
    }

    private bool Interact()
    {
        string? option = Console.ReadLine();

        switch (option)
        {
            case "1":
                Console.WriteLine("Enter title");
                string? title = Console.ReadLine();
                Console.WriteLine("Enter author");
                string? author = Console.ReadLine();
                Console.WriteLine("Enter publisher");
                string? publisher = Console.ReadLine();
                _fiction.Books.Add(new Book(title, author, publisher));
                break;
            case "2":
                Console.WriteLine("Enter title");
                string? title2 = Console.ReadLine();
                Console.WriteLine("Enter author");
                string? author2 = Console.ReadLine();
                Console.WriteLine("Enter publisher");
                string? publisher2 = Console.ReadLine();
                _nonFiction.Books.Add(new Book(title2, author2, publisher2));
                break;
            case "4":
                Console.WriteLine("Enter string to search for:");
                string? search2 = Console.ReadLine();
                if (!string.IsNullOrEmpty(search2))
                {
                    foreach (var book in _nonFiction.Books)
                    {
                        if (book.Author.ToLower().Contains(search2.ToLower()))
                        {
                            Console.WriteLine(book.Title);
                        }
                    }

                    foreach (var book in _fiction.Books)
                    {
                        if (book.Author.ToLower().Contains(search2.ToLower()))
                        {
                            Console.WriteLine(book.Title);
                        }
                    }
                }

                break;
            case "5":
                Console.WriteLine("Enter string to search for:");
                string? search = Console.ReadLine();
                if (!String.IsNullOrEmpty(search))
                {
                    foreach (var book in _nonFiction.Books)
                    {
                        if (book.Title.ToLower().Contains(search.ToLower()))
                        {
                            Console.WriteLine(book.Title);
                        }
                    }

                    foreach (var book in _fiction.Books)
                    {
                        if (book.Title.ToLower().Contains(search.ToLower()))
                        {
                            Console.WriteLine(book.Title);
                        }
                    }
                }

                break;
            case "8":
                Console.WriteLine("### NON-FICTION ###");
                foreach (var book in _nonFiction.Books)
                {
                    Console.WriteLine(book.Title);
                }

                break;
            case "9":
                Console.WriteLine("### FICTION ###");
                foreach (var book in _fiction.Books)
                {
                    Console.WriteLine(book.Title);
                }

                break;
            case "0":
                return false;
                break;
        }

        return true;
    }
}