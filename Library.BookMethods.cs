partial class Library
{
    public void AddBook(Book book)
    {
        foreach (Book existingbook in books)
        {
            if (existingbook.ID == book.ID)
            {
                Console.WriteLine("Book Already Exists");
                return;
            }
        }
        books.Add(book);
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

    public Book UpdateBook()
    {
        Book book = SearchBook();

        if (book == null)
        {
            Console.WriteLine("Book Not Found");
            return null;
        }
        Console.WriteLine("What do you want to update?");
        Console.WriteLine("1. Title");
        Console.WriteLine("2. Author");
        Console.WriteLine("3. Category");

        int updatechoice = GetUpdateChoice();

        switch (updatechoice)
        {
            case 1:
                Console.WriteLine();
                Console.WriteLine("Update Title Selected");

                string newtitle = GetBookTitle();
                book.Title = newtitle;

                Console.WriteLine($"Book title updated to: {book.Title}");

                break;

            case 2:

                Console.WriteLine();
                Console.WriteLine("Update Author Selected");

                string newauthor = GetBookAuthor();
                book.Author = newauthor;

                Console.WriteLine($"Book Author updated to: {book.Author}");

                break;

            case 3:

                Console.WriteLine();
                Console.WriteLine("Update Category Selected");

                string newcategory = GetBookCategory();
                book.Category = newcategory;

                Console.WriteLine($"Book Category updated to: {book.Category}");

                break;
        }
        return book;
    }
    public void DeleteBook()
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
        books.Remove(book);
        Console.WriteLine("Book deleted Successfully");
    }
    public void DeleteMember()
    {
        Member member = SearchMember();
        if (member == null)
        {
            Console.WriteLine("Member Not Found");
            return;
        }
        if (member.BorrowedBooks.Count > 0)
        {
            Console.WriteLine("Member has borrowed books.\r\nCannot delete member.");
            return;
        }
        members.Remove(member);
        Console.WriteLine("Member removed Successfully");

    }

}