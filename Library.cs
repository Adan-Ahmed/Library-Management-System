class Library 
{
    private List<Book> books = new List<Book>();
    private List<Member> members = new List<Member>();

    public void AddBook( Book book)
    {
        books.Add(book);
    }
    public void AddMember( Member member)
    {
        members.Add(member);
    }
    public void ViewBooks() 
    {
        foreach (Book book in books)
        {
            Console.WriteLine(book.ID);
            Console.WriteLine(book.Title);
            Console.WriteLine(book.Author);
            Console.WriteLine(book.Category);
            Console.WriteLine(book.IsAvailable);
            Console.WriteLine();
        }
    }
    public void ViewMembers() 
    {
        foreach (Member member in members)
        {
            Console.WriteLine(member.ID);
            Console.WriteLine(member.Name);
            Console.WriteLine(member.Email);
            Console.WriteLine();
        }
    }
}