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
            BorrowRecord borrowrecord = new BorrowRecord(book, member, DateTime.Now, DateTime.Now.AddDays(7));
            book.IsAvailable = false;
            member.BorrowedBooks.Add(borrowrecord);
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

        foreach (BorrowRecord record in member.BorrowedBooks)
        {
            Console.WriteLine($"Book ID:{record.Book.ID} " +
                $"\nBook Title: {record.Book.Title} " +
                $"\nBorrow Date: {record.BorrowDate} " +
                $"\nDue Date: {record.DueDate}");
                ShowRemainingTime(record);

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
        BorrowRecord foundRecord = null;

        foreach (BorrowRecord record in member.BorrowedBooks)
        {
            if (id == record.Book.ID)
            {
                foundRecord = record;
                break;
            }
        }


        if (foundRecord == null)
        {
            Console.WriteLine("This member did not borrow this book");
            return;
        }
        Console.WriteLine($"Book found successfully: \n{foundRecord.Book.ID} : {foundRecord.Book.Title}");
       
        int fine = CalculateFine(foundRecord);
        if (fine > 0)
        {
            Console.WriteLine($"Your fine is: Rs. {fine}");
        }
        else 
        {
            Console.WriteLine("No fine. Book returned on time.");
        }
        foundRecord.Book.IsAvailable = true;
        member.BorrowedBooks.Remove(foundRecord);
        Console.WriteLine("Book returned successfully");

    }
}