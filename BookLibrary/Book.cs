namespace BookLibrary;

public class Book
{
    public Book(string name, string author, string genre, int year)
    {
        Title = name;
        Author = author;
        Genre = genre;
        Year = year;
    }

    public string Title { get; private set; }
    public string Author { get; private set; }
    public string Genre { get; private set; } 
    public int Year { get; private set; }

    public void ShowInfo()
    {
        Console.WriteLine($"{Author}: {Title}, {Year}, {Genre}");
    }
}