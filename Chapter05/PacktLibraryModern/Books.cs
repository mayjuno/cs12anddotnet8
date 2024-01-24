using System.Diagnostics.CodeAnalysis; // To use [SetsRequiredMembers].
namespace Packt.Shared;

public class Book
{
    #region Fields: Book
    // Needs .Net 7 or later as well as C# 11 or later
    public required string? Isbn;
    public required string? Title;

    // Work with any version of .Net.
    public string? Author;
    public int PageCount;
    #endregion

    #region Constructor: Book
    // Constructor for use with object initalizer syntax.
    public Book() { }

    // Constructor with parameters to set required fields.
    [SetsRequiredMembers]
    public Book(string? isbn, string? title)
    {
        Isbn = isbn;
        Title = title;
    }
    public Book(string? isbn, string? title, string? author, int pageCount)
    {
        Isbn = isbn;
        Title = title;
        Author = author;
        PageCount = pageCount;
    }
    #endregion


}

