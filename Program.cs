using System;

class Program 
{
    static void Main(string[] args) 
    {
        List<Book> list = new List<Book>();
        Book book1 = new Book(1, "Code With C#", "Mrs John", "Tech", true);
        Book book2 = new Book(2, "Python", "Mrs John", "Tech", true);
        Book book3 = new Book(3, "HTML", "Mrs John", "Tech", true);
            list.Add(book2);
            list.Add(book3);
            list.Add(book1);
        //Console.WriteLine(book.Title);
        foreach (Book book in list) 
        {
            Console.WriteLine(book.ID);
            Console.WriteLine(book.Title);
            Console.WriteLine(book.Author);
            Console.WriteLine(book.Category);
            Console.WriteLine(book.IsAvailable);
            Console.WriteLine();
        }

    
    }
}