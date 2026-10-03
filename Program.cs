using System;

class Program 
{
    static void AddBook(Library library) 
    {
        int id = library.GetBookID();
        string title = library.GetBookTitle();
        string author = library.GetBookAuthor();
        string category = library.GetBookCategory();
        bool availability = library.GetBookAvailability();
        Book book = new Book(id, title, author, category, availability);
        library.AddBook(book);
    }
    static void AddMember(Library library)
    {
        int id = library.GetMemberID();
        string name = library.GetMemberName();
        string email = library.GetMemberEmail();
        Member member = new Member(id, name, email);
        library.AddMember(member);
    }
    static void Main(string[] args) 
    {
        Library library = new Library();
        while (true) 
        {
            Console.WriteLine();
            Console.WriteLine("========== Library Management System ==========");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View Book");
            Console.WriteLine("3. Search Book");
            Console.WriteLine("4. Add Member");
            Console.WriteLine("5. View Members");
            Console.WriteLine("6. Search Members");
            Console.WriteLine("7. Borrow Book");
            Console.WriteLine("8. Return Book");
            Console.WriteLine("9. View Borrowed Books");
            Console.WriteLine("10. Exit");

            int choice = library.GetChoice();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Add Book Selected");
                    AddBook(library);
                    break;

                case 2:
                    Console.WriteLine();
                    Console.WriteLine("View Book Selected");
                    library.ViewBooks();
                    break;

                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Search Book Selected");
                    
                    Book bookresult = library.SearchBook();

                    if (bookresult == null)
                    {
                        Console.WriteLine("Book Not Found");
                    }
                    else
                    {
                        Console.WriteLine($"Book Found: \n{bookresult.Title} \n{bookresult.Author} \n{bookresult.Category} \n{bookresult.IsAvailable}");
                    }

                    break;

                case 4:
                    Console.WriteLine();
                    Console.WriteLine("Add Member Selected");
                    AddMember(library);
                    break;

                case 5:
                    Console.WriteLine();
                    Console.WriteLine("View Member Selected");
                    library.ViewMembers();
                    break;

                case 6:
                    Console.WriteLine();
                    Console.WriteLine("Search Member Selected");
                    Member memberresults = library.SearchMember();

                    if (memberresults == null)
                    {
                        Console.WriteLine("Member Not Found");
                    }
                    else
                    {
                        Console.WriteLine($"{memberresults.ID} : {memberresults.Name}");
                    }
                    break;

                case 7:
                    Console.WriteLine();
                    Console.WriteLine("Borrow Book Selected");
                    library.BorrowBook();
                    break;

                case 8:
                    Console.WriteLine();
                    Console.WriteLine("Return Book");
                    library.ReturnBook();
                    break;

                case 9:
                    Console.WriteLine();
                    Console.WriteLine("View Borrowed Books Selected");
                    library.ViewBorrowedBooks();
                    break;

                case 10:
                    Console.WriteLine("Thank you for using Library Management System.");
                    return;

            }

        }

        //Book book1 = new Book(1, "Code With C#", "Mrs John", "Tech", true);
        //Book book2 = new Book(2, "Python", "Mrs John", "Tech", true);
        //Book book3 = new Book(3, "HTML", "Mrs John", "Tech", true);
        //library.AddBook(book1);
        //library.AddBook(book2);
        //library.AddBook(book3);
        //AddBook(library);
        //library.ViewBooks();
        //foreach (Book book  in books) 
        //{
        //    Console.WriteLine(book.ID);
        //    Console.WriteLine(book.Title);
        //    Console.WriteLine(book.Author);
        //    Console.WriteLine(book.Category);
        //    Console.WriteLine(book.IsAvailable);
        //    Console.WriteLine();
        //}


        //Member member1 = new Member(1, "Adan", "adan@gmail.com");
        //Member member2 = new Member(2, "Ahmed", "ahmed@gmail.com");
        //Member member3 = new Member(3, "Taha", "taha@gmail.com");
        //library.AddMember(member1); 
        //library.AddMember(member2); 
        //library.AddMember(member3);
        //AddMember(library);
        //library.ViewMembers();

        //foreach (Member member in members) 
        //{
        //    Console.WriteLine(member.ID);
        //    Console.WriteLine(member.Name);
        //    Console.WriteLine(member.Email);
        //    Console.WriteLine();
        //}
        //Book bookresult = library.SearchBook();
                
        //if (bookresult == null)
        //{
        //    Console.WriteLine("Book Not Found");
        //}
        //else 
        //{
        //    Console.WriteLine($"Book Found: \n{bookresult.Title} \n{bookresult.Author} \n{bookresult.Category} \n{bookresult.IsAvailable}"); 
        //}

        //library.BorrowBook();

        //Member memberresults = library.SearchMember();

        //if (memberresults == null)
        //{
        //    Console.WriteLine("Member Not Found");
        //}
        //else
        //{
        //    Console.WriteLine($"{memberresults.ID} : {memberresults.Name}");
        //}

    }
}