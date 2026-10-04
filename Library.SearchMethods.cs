partial class Library
{
    public Book SearchBook()
    {

        int id = GetSearchBookID();

        foreach (Book book in books)
        {
            if (book.ID == id)
            {
                return book;
            }
        }
        return null;
    }

    public Book SearchBookByTitle()
    {
        string title;
        Console.WriteLine("Enter the Title of Book");
        title = Console.ReadLine();

        foreach (Book book in books)
        {
            if (book.Title.ToLowerInvariant().Contains(title.ToLowerInvariant()))
            {
                return book;
            }

        }
        return null;
    }

    public Member SearchMember()
    {
        int id = GetMemberID();
        foreach (Member member in members)
        {
            if (member.ID == id)
            {
                return member;
            }
        }
        return null;
    }


}