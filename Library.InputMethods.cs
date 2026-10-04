partial class Library
{
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
        int updatechoice;

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