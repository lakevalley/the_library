namespace The_Library;

public class NonFiction : Shelf
{
    public NonFiction()
    {
        Books.Add(new Book("Sapiens: A Brief History of Humankind", "Yuval Noah Harari", "Vintage"));
        Books.Add(new Book("Quiet: The Power of Introverts in a World That Can't Stop Talking", "Susan Cain", "Crown Publishing Group/Random House, Inc"));
        Books.Add(new Book("The Immortal Life of Henrietta Lacks", "Rebecca Skloot", "Crown Publishing Group"));
        Books.Add(new Book("Krigar-dinosaurier", "Ruth Owen", "Hegas"));
    }
}