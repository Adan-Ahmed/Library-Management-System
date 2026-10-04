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
            Console.WriteLine("10. Update Books");
            Console.WriteLine("11. Update Member");
            Console.WriteLine("12. Delete Book");
            Console.WriteLine("13. Delete Member");
            Console.WriteLine("14. Exit");

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
                    Console.WriteLine("Search Book\r\n1. Search by ID\r\n2. Search by Title");

                    int choose = library.GetSearchChoice();

                    switch (choose) 
                    {
                        case 1:
                            Console.WriteLine("Search by ID Selected");
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

                        case 2:
                            Console.WriteLine("Search by Title Selected");
                            Book booktitle = library.SearchBookByTitle();

                            if (booktitle == null) 
                            {
                                Console.WriteLine("Book title Not Found");
                            }
                            else
                            {
                                Console.WriteLine($"Book Found: \n{booktitle.Title} \n{booktitle.Author} \n{booktitle.Category} \n{booktitle.IsAvailable}");
                            }

                            break;
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
                    Console.WriteLine();
                    Console.WriteLine("Update Books Selected");
                    library.UpdateBook();

                    break;

                case 11:
                    Console.WriteLine();
                    Console.WriteLine("Update Members Selected");
                    library.UpdateMember();

                    break;

                case 12:
                    Console.WriteLine();
                    Console.WriteLine("Delete Book Selected");
                    library.DeleteBook();
                    break;

                case 13:
                    Console.WriteLine();
                    Console.WriteLine("Delete Member Selected");
                    library.DeleteMember();
                    break;


                case 14:
                    Console.WriteLine("Thank you for using Library Management System.");
                    return;
            }
        }
    }
}