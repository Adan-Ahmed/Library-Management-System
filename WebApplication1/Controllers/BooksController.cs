
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]

public class BooksController : ControllerBase
{
    [HttpGet]
    public List<Book> GetBooks() 
    {
        List<Book> books = new List<Book>();
        Book book1 = new Book
        {
            Id = 1,
            Title = "API Concept",
            Author = "Sir Rizwan"
        };
        Book book2 = new Book
        {
            Id = 2,
            Title = "C# Fundamentals",
            Author = "Sir Ali"
        };
        Book book3 = new Book
        {
            Id = 3,
            Title = "ASP.NET Core",
            Author = "Sir Shoiab"
        };


        books.Add(book1);
        books.Add(book2);
        books.Add(book3);
        return books;

    }

}
