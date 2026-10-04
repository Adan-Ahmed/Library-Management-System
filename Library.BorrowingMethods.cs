partial class Library
{
    public void BorrowBook()
    {
        Member member = SearchMember();
        if (member == null)
        {
            Console.WriteLine("Member not found");
            return;
        }
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
            member.BorrowedBooks.Add(book);
            Console.WriteLine("Book Borrowed Successfully");

        }

    }

    public void ViewBorrowedBooks()
    {
        Member member = SearchMember();
        if (member == null)
        {
            Console.WriteLine("Member not found");
            return;
        }

        if (member.BorrowedBooks.Count == 0)
        {
            Console.WriteLine("This member has no borrowed books");
            return;
        }

        foreach (Book book in member.BorrowedBooks)
        {
            Console.WriteLine($"Book ID:{book.ID} \nBook Title: {book.Title}");
        }
    }

    public void ReturnBook()
    {
        Member member = SearchMember();
        if (member == null)
        {
            Console.WriteLine("Member not found");
            return;
        }
        int id = GetSearchBookID();
        Book foundbook = null;

        foreach (Book book in member.BorrowedBooks)
        {
            if (id == book.ID)
            {
                foundbook = book;
                break;
            }
        }


        if (foundbook == null)
        {
            Console.WriteLine("This member did not borrow this book");
            return;
        }
        Console.WriteLine($"Book found successfully: \n{foundbook.ID} : {foundbook.Title}");
        foundbook.IsAvailable = true;
        member.BorrowedBooks.Remove(foundbook);
        Console.WriteLine("Book returned successfully");
    }
}