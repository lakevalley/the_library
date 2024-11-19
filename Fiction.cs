namespace The_Library;

public class Fiction : Shelf
{
    public Fiction()
    {
        Books.Add(new Book("The Fellowship of the Ring", "J. R. R. Tolkien", "Allen & Unwin"));
        Books.Add(new Book("The Two Towers", "J. R. R. Tolkien", "Allen & Unwin"));
        Books.Add(new Book("The Return of the King", "J. R. R. Tolkien", "Allen & Unwin"));
        Books.Add(new Book("Väninnorna på Nordiska Kompaniet", "Ruth Kvarnström-Jones", "Printz"));
        Books.Add(new Book("The Pumpkin Spice Café", "Laurie Gilmore", "HarperCollins"));
        Books.Add(new Book("The Hunger Games","Suzanne Collins","Scholastic Press"));
    }
}