using ConsoleApp45;
using ConsoleApp45;
BookService service = new BookService();
Book book1 = new Book
{
    Title = "C# Programming",
    Author = "John Doe",
    PageCount = 300,
    Price = 29.99m,
    StockCount = 10,
    Genre = Genre.Programming
};
Book book2 = new Book
{
    Title = "Physics for Beginners",
    Author = "Jane Smith",
    PageCount = 250,
    Price = 19.99m,
    StockCount = 5,
    Genre = Genre.Science
};
Book book3 = new Book
{
    Title = "World History",
    Author = "Alice Johnson",
    PageCount = 400,
    Price = 24.99m,
    StockCount = 8,
    Genre = Genre.History
};
Book book4 = new Book
{
    Title = "The Great Novel",
    Author = "Robert Brown",
    PageCount = 350,
    Price = 14.99m,
    StockCount = 12,
    Genre = Genre.Novel
};
Book book5 = new Book
{
    Title = "Mystery of the Unknown",
    Author = "Emily White",
    PageCount = 280,
    Price = 9.99m,
    StockCount = 7,
    Genre = Genre.Outher
};
Book book6 = new Book
{
    Title = "Advanced C# Techniques",
    Author = "Michael Green",
    PageCount = 450,
    Price = 39.99m,
    StockCount = 6,
    Genre = Genre.Programming
};
service.Add(book1);
service.Add(book2);
service.Add(book3);
service.Add(book4);
service.Add(book5);
service.Add(book6);
Book result = service.GetById(3);
Console.WriteLine(result.GetShortInfo());
Book cheapestBook = service.GetCheapestBook();
Console.WriteLine(cheapestBook.GetShortInfo());
Book mostExpensiveBook = service.GetMostExpensiveBook();
Console.WriteLine(mostExpensiveBook.GetShortInfo());
double averagePrice = (double)service.GetAveragePrice();
int countByGenre = service.CountByGenre(Genre.Programming);
Book copy = book1.ShallowCopy();
Console.WriteLine(copy.GetShortInfo());