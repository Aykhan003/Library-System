namespace ConsoleApp45;

internal static class BookExtension
{
    public static string GetShortInfo(this Book book)
    {
        return $"Title: {book.Title}, Author: {book.Author}, Price: {book.Price}";
    }
    public static bool IsInStock(this Book book)
    {
        return book.StockCount > 0;
    }
    public static void ApplyDiscount(this Book book, decimal discountPercentage)
    {
        decimal discountAmount = book.Price * (discountPercentage / 100);
        book.Price -= discountAmount;
    }
}
