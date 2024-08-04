using System.Text.RegularExpressions;

namespace Store;

public class Book
{
    public int Id { get; }
    public string Isbn { get; }
    public string Author { get; }
    public string Title { get; }

    public Book(int id,string isbn, string author, string title)
    {
        Id = id;
        Isbn = isbn;
        Author = author;
        Title = title;
    }
    public static bool IsIsbm(string s)
    {
        if (s == null) return false;

        s = s.Replace("-", "")
             .Replace("_", "")
             .Replace(" ", "")
             .ToUpper();

        return Regex.IsMatch(s, @"ISBN\d{10}?(\d3)?$");
    }
}
