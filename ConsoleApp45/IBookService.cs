namespace ConsoleApp45;

internal interface IBookService
{
    public void Add(Book book);
    public void GetById(int id);
    public void GetByGenre(Genre genre);
    public void GetMostExpensiveBook();
    public void GetCheapestBook();
    public void GetAveragePrice();
    public void CountByGenre(Genre genre);
    public void GetByPriceRange(decimal minPrice, decimal maxPrice);
}
