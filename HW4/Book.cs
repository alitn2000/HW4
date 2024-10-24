
using System.Diagnostics;

namespace HW4;

internal class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public int Pages { get; set; }
    public string Genre { get; set; }
    public int PublishedYear { get; set; }

    private double Price;

    public double price
    {
        get { return Price; }

    }
    public void SetPrice(double newPrice)
    {
        if (newPrice >= 0)
        {
            Price = newPrice;
        }
        else
        {
            throw new ArgumentException("Price cannot be negative.");
        }
    }
    public Book(string title, string author, string publisher, int pages, double initialPrice, string genre, int publishedyear)
    {

        Title = title;
        Author = author;
        Publisher = publisher;
        Pages = pages;
        Price = price;
        Genre = genre;
        PublishedYear = publishedyear;
        SetPrice(initialPrice);

    }

    public void show()
    {
        Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nPublisher: {Publisher}\nYear: {PublishedYear}\n Price: {price}");
        Console.WriteLine("--------------------------------------------------------------------------------------------------");
    }

    public void PricePlus (double p)
    {
        price += p;
    }

    public List<Book> GetBooks(Book[] books, string author)
    {
        List<Book> authors = new List<Book>();

        foreach (var b in books)
        {
            if (b.Author == author) 
            {
                authors.Add(b);
            }
        }

        return authors;
    }

}
