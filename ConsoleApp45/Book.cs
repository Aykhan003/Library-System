namespace ConsoleApp45;

internal class Book
{
    private static int _id;
    public int Id { get; set; }
    public string Author { get; set; } = null!;
    public string Title { get; set; } = null!;
    public int PageCount { get; set; }
    public decimal Price { get; set; }
    public int StockCount { get; set; }
    public Genre Genre { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public Book(string title,string author, int pageCount, decimal price, int stockCount, Genre genre)
    {
         _id++;
        Id = _id;
        Title = title;
        Author = author;
        PageCount = pageCount;
        Price = price;
        StockCount = stockCount;
        Genre = genre;
    }
    public Book()
    {
        _id++;
        Id = _id;
    }
    public Book ShallowCopy()
    {
        return (Book)this.MemberwiseClone();
    }
}
