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
    public Book GetById(int id)
    {
        var book = _books.Find(b => b.Id == id);
        if (book == null)
        {
            throw new FileNotFoundException("Book not found");
        }
        return book;
    }
    public int CountByGenre(Genre genre)
    {
        var count = _books.Count(b => b.Genre == genre);
        return count;
    }

    public decimal GetAveragePrice()
    {
        var average = _books.Average(b => b.Price);
        return average;
    }

    public List<Book> GetByGenre(Genre genre)
    {
        return _books.Where(b => b.Genre == genre).ToList();
    }
    public List<Book> GetByPriceRange(decimal minPrice, decimal maxPrice)
    {
        var books = _books.Where(b => b.Price >= minPrice && b.Price <= maxPrice);
        return books.ToList();
    }
    public Book GetCheapestBook()
    {
        var book = _books.OrderBy(b => b.Price).FirstOrDefault();
        if (book == null)
        {
            throw new FileNotFoundException("Book not found");
        }
        return book;
    }

    public Book GetMostExpensiveBook()
    {
        var book = _books.OrderByDescending(b => b.Price).FirstOrDefault();
        if (book == null)
        {
            throw new FileNotFoundException("Book not found");
        }
        return book;
    }
}