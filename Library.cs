partial class Library
{
    private List<Book> books = new List<Book>();
    private List<Member> members = new List<Member>();

    public List<Book> SearchBookByTitle()
    {
        List<Book> results = new List<Book>();
        string title;
        Console.WriteLine("Enter the Title of Book");
        title = Console.ReadLine();

        foreach (Book book in books)
        {
            if (book.Title.ToLowerInvariant().Contains(title.ToLowerInvariant()))
            {
                results.Add(book);
            }
        }
        return results;
    }

    //public Book SearchBookByTitle()
    //{
    //    string title;
    //    Console.WriteLine("Enter the Title of Book");
    //    title = Console.ReadLine();

    //    foreach (Book book in books)
    //    {
    //        if (book.Title.ToLowerInvariant().Contains(title.ToLowerInvariant()))
    //        {
    //            return book;
    //        }

    //    }
    //    return null;
    //}
}


