namespace ConsoleApp45;

internal class BookService : IBookService
{
    static List<Book> _books = new List<Book>();
    public void Add(Book book)
    {
        foreach (var item in _books)
        {
            if (item.Title == book.Title && item.Author == book.Author)
            {
                throw new ConflictException ("This book already exists");
            }
        }
        _books.Add(book);
    }

    public void CountByGenre(Genre genre)
    {
        var count = _books.Count(b => b.Genre == genre);
        Console.WriteLine($"Number of books in {genre}: {count}");
    }

    public void GetAveragePrice()
    {
        var average = _books.Average(b => b.Price);
        Console.WriteLine($"Average price of all books: {average}");
    }

    public void GetByGenre(Genre genre)
    {
        var books = _books.Where(b => b.Genre == genre);
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Price: {book.Price}");
        }
    }

    public void GetById(int id)
    {
        var book = _books.Find(b => b.Id == id);
        if (book != null)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Price: {book.Price}");
        }
        else
        {
            Console.WriteLine("Book not found");
        }
    }

    public void GetByPriceRange(decimal minPrice, decimal maxPrice)
    {
        var books = _books.Where(b => b.Price >= minPrice && b.Price <= maxPrice);
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Price: {book.Price}");
        }
    }

    public void GetCheapestBook()
    {
        var book = _books.OrderBy(b => b.Price).FirstOrDefault();
        if (book != null)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Price: {book.Price}");
        }
        else
        {
            Console.WriteLine("No books available");
        }
    }

    public void GetMostExpensiveBook()
    {
        var book = _books.OrderByDescending(b => b.Price).FirstOrDefault();
        if (book != null)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Price: {book.Price}");
        }
        else
        {
            Console.WriteLine("No books available");
        }
    }
}
