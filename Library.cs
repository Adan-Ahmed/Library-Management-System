
partial class Library
{
    private List<Book> books = new List<Book>();
    private List<Member> members = new List<Member>();





    public int GetBookID()
    {
        int id;
        while (true)
        {
            Console.WriteLine("Enter the Book ID: ");
            if (int.TryParse(Console.ReadLine(), out id))
            {
                if (id > 0)
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

    public string GetBookTitle()
    {
        string title;
        while (true)
        {
            Console.WriteLine("Enter the Book Title: ");
            title = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Please enter a valid title");
                continue;
            }
            break;
        }
        return title;
    }
    public string GetBookAuthor()
    {
        string author;
        while (true)
        {
            Console.WriteLine("Enter the Book Author: ");
            author = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(author))
            {
                Console.WriteLine("Please enter a valid Author");
                continue;
            }
            break;
        }
        return author;
    }

    public string GetBookCategory()
    {
        string category;
        while (true)
        {
            Console.WriteLine("Enter the Book Category: ");
            category = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(category))
            {
                Console.WriteLine("Please enter a valid Category");
                continue;
            }

            if (category.Length > 20)
            {
                Console.WriteLine("Category must be 20 characters or less");
                continue;
            }
            break;
        }
        return category;
    }

    public bool GetBookAvailability()
    {
        string Availabilty;
        while (true)
        {
            Console.WriteLine("Enter the Book Availabilty: ");
            Availabilty = Console.ReadLine();
            Availabilty = Availabilty.ToLowerInvariant();
            if (Availabilty == "yes")
            {
                return true;
            }
            if (Availabilty == "no")
            {
                return false;
            }
            Console.WriteLine("Enter valid Input ");
            continue;
        }
    }
    public int GetSearchBookID()
    {
        int id;
        while (true)
        {
            Console.WriteLine("Enter the Book ID you want to search:");
            if (int.TryParse(Console.ReadLine(), out id))
            {
                if (id > 0)
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
    public int GetMemberID()
    {
        int id;
        while (true)
        {
            Console.WriteLine("Enter the member ID:");
            if (int.TryParse(Console.ReadLine(), out id))
            {
                if (id > 0)
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
    public string GetMemberName()
    {
        string name;
        while (true)
        {
            Console.WriteLine("Enter the member name: ");
            name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Please enter a valid name");
                continue;
            }
            break;
        }
        return name;
    }
    public string GetMemberEmail()
    {
        string Email;
        while (true)
        {
            Console.WriteLine("Enter the Member Email: ");
            Email = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(Email))
            {
                Console.WriteLine("Please enter a valid Email");
                continue;
            }
            if (!Email.Contains("@") || !Email.Contains("."))
            {
                Console.WriteLine("Please enter a valid Email format");
                continue;
            }
            break;
        }
        return Email;
    }
 

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

    public int GetChoice()
    {
        int choice;

        while (true)
        {
            Console.WriteLine("Enter your choice: 1 to 14");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice >= 1 && choice <= 14)
                {
                    break;
                }

                Console.WriteLine("Choice must be between 1 and 14.");
            }
            else
            {
                Console.WriteLine("Please enter a valid choice number.");
            }
        }

        return choice;
    }
 

    public int GetSearchChoice()
    {
        int choose;

        while (true)
        {
            Console.WriteLine("Enter your choice (1 or 2):");

            if (int.TryParse(Console.ReadLine(), out choose))
            {
                if (choose >= 1 && choose <= 2)
                {
                    break;
                }

                Console.WriteLine("Choice must be either 1 or 2.");
            }
            else
            {
                Console.WriteLine("Please enter a valid choice number.");
            }
        }

        return choose;
    }

 
    public int GetUpdateChoice() 
    {
        int  updatechoice;

        while (true)
        {
            Console.WriteLine("Enter your choice 1 to 3:");

            if (int.TryParse(Console.ReadLine(), out updatechoice))
            {
                if (updatechoice >= 1 && updatechoice <= 3)
                {
                    break;
                }

                Console.WriteLine("Choice must be 1 to 3.");
            }
            else
            {
                Console.WriteLine("Please enter a valid choice number.");
            }
        }

        return updatechoice;
    }

 
    public int GetUpdateMember()
    {
        int updatemember;

        while (true)
        {
            Console.WriteLine("Enter your choice 1 or 2:");

            if (int.TryParse(Console.ReadLine(), out updatemember))
            {
                if (updatemember >= 1 && updatemember <= 2)
                {
                    break;
                }

                Console.WriteLine("Choice must be either 1 or 2.");
            }
            else
            {
                Console.WriteLine("Please enter a valid choice number.");
            }
        }

        return updatemember;
    }

 
}


