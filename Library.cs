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

    public int GetID()
    {
        int id;
        while (true) 
        {
            Console.WriteLine("Enter the Book ID you want to search:");
            if(int.TryParse(Console.ReadLine(), out id))
            {
                if(id > 0)
                {
                    break;
                }
                Console.WriteLine("ID must be greater than Zero");
            }
            else
            {
                Console.WriteLine("Enter the valid ID number");
            }
        }
        return id;
    }
    public Book SearchBook()
    {
        int id = GetID();

        foreach (Book book in books) 
        {
            if (book.ID == id)
            {
                return book;
            }
        }
        return null;

    }

    public void BorrowBook() 
    {
        Book book = SearchBook();
        if (book == null)
        {
            Console.WriteLine("Book Not Found");
            return;
        }
        if (book.IsAvailable == false)
        {
            Console.WriteLine("Book is already borrowed");
            return;
        }
        else
        {
            book.IsAvailable = false;
            Console.WriteLine("Book Borrowed Successfully");
        }
    }
    
    public Member SearchMember()
    {
        Console.WriteLine("Enter the Member ID");
        GetID();
        foreach (Member member in members) 
        {

        }
    }
}