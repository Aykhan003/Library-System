namespace ConsoleApp45;

internal interface IBookService
{
    public void Add(Book book);
    public Book GetById(int id);
    List<Book> GetByGenre(Genre genre);
    public Book GetMostExpensiveBook();
    public Book GetCheapestBook();
    public decimal GetAveragePrice();
    public int CountByGenre(Genre genre);
    List<Book> GetByPriceRange(decimal minPrice, decimal maxPrice);
}
