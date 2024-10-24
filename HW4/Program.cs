using HW4;

Book[] books = new Book[]
      {
            new Book("book1", "A", "Publisher1", 200, 1000, "Novel", 2020),
            new Book("book2", "B", "Publisher2", 201, 2000, "Fiction", 2004),
            new Book("book3", "C", "Publisher3", 202, 3000, "Dystopian", 1999),
            new Book("book4", "C", "Publisher4", 203, 4000, "Satire", 1987)
      };
foreach (var book in books)
{
    book.show();
}
books[0].PricePlus(10000);
Console.WriteLine("***************************Plus***************************:");
books[0].show();

Book bookObject = new Book("", "", "", 0, 0, "", 0);
Console.WriteLine("***************************publisher (C):***************************");
List<Book> c = bookObject.GetBooks(books, "C");
foreach (var book in c)
{
    book.show();
}