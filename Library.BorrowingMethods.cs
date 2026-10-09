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

        if (member.BorrowedBooks.Count >= 3)
        {
            Console.WriteLine("You cannot borrow more than 3 book. ");
            return;
        }


        Book book = SearchBook();

        if (book == null)
        {
            Console.WriteLine("Book Not Found");
            return;
        }

        foreach (BorrowRecord record in member.BorrowedBooks) 
        {
            if(record.BookID == book.ID) 
            {
                Console.WriteLine("\"Member already has this book\"");
                return;
            }
        }
        if (book.IsAvailable == false)
        {
            Console.WriteLine("Book is already borrowed");
            return;
        }
        else
        {
            BorrowRecord borrowrecord = new BorrowRecord(book.ID, member.ID, DateTime.Now, DateTime.Now.AddDays(7));
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
            Book book = books.Find(b=> b.ID == record.BookID);
            Console.WriteLine($"Book ID:{record.BookID} " +
                $"\nBook Title: {book.Title} " +
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
            if (id == record.BookID)
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
        Book book = books.Find(b => b.ID == foundRecord.BookID);
        Console.WriteLine($"Book found successfully: \n{foundRecord.BookID} : {book.Title}");
       
        int fine = CalculateFine(foundRecord);
        if (fine > 0)
        {
            Console.WriteLine($"Your fine is: Rs. {fine}");
        }
        else 
        {
            Console.WriteLine("No fine. Book returned on time.");
        }
        book.IsAvailable = true;
        member.BorrowedBooks.Remove(foundRecord);
        Console.WriteLine("Book returned successfully");

    }
}