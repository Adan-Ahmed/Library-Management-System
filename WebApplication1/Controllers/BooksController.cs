
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
        Book book = new Book
        {
            Id = 1,
            Title = "API Concept",
            Author = "Sir Rizwan"
        };

        books.Add(book);
        return books;

    }

}
