using WebApplication1.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]

public class BooksController : ControllerBase
{
    private readonly BookService _bookService;
    public BooksController(BookService bookService) 
    {
        _bookService = bookService;
    }

    [HttpGet]
    public List<Book> GetBooks() 
    {
        //Book book1 = new Book
        //{
        //    Id = 1,
        //    Title = "API Concept",
        //    Author = "Sir Rizwan"
        //};
        //Book book2 = new Book
        //{
        //    Id = 2,
        //    Title = "C# Fundamentals",
        //    Author = "Sir Ali"
        //};
        //Book book3 = new Book
        //{
        //    Id = 3,
        //    Title = "ASP.NET Core",
        //    Author = "Sir Shoiab"
        //};


        //_bookService.Books.Add(book1);
        //_bookService.Books.Add(book2);
        //_bookService.Books.Add(book3);
        return _bookService.Books;

    }

    [HttpPost]
    public IActionResult AddBook([FromBody] Book book)
    {
        _bookService.Books.Add(book);
        return Ok(book);
    }

}
