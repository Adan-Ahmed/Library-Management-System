using System.Text.Json;
using System.Text.Json.Serialization;
partial class Library
{
    private List<Book> books = new List<Book>();
    private List<Member> members = new List<Member>();



    //public Book SearchBookByTitle()
    //{
    //    string title;
    //    Console.WriteLine("Enter the Title of Book");
    //    title = Console.ReadLine();

    //    foreach (Book book in books)
    //    {
    //        if (book.Title.ToLowerInvariant().Contains(title.ToLowerInvariant()))
    //        {
    //            return book;
    //        }

    //    }
    //    return null;
    //}

    public void ShowRemainingTime(BorrowRecord record) 
    {
        if (record.DueDate > DateTime.Now) 
        { 
            TimeSpan remaining = record.DueDate - DateTime.Now;
            Console.WriteLine($"You have {remaining.Days} days and {remaining.Hours} hours left.");
        }
        else 
        {
            Console.WriteLine("Book is Over due");
        }
    }

    public int CalculateFine(BorrowRecord record) 
    {
        int fine = 0;

        if (record.DueDate < DateTime.Now)
        {
            TimeSpan overdue = DateTime.Now - record.DueDate;
            int Rupees = 50;
            fine = Rupees * overdue.Days;
            Console.WriteLine($"Your fine is: {fine}");
            
        }
        else 
        {
            Console.WriteLine("Book is not overdue");
        }
        return fine;
    }


    public void StoreData() 
    {
        string json = JsonSerializer.Serialize(books);
        File.WriteAllText("books.json", json);

    }

    public void LoadData() 
    {
        if (!File.Exists("books.json")) 
        {
            return;
        }
        string json = File.ReadAllText("books.json");
        List<Book> loadedBooks = JsonSerializer.Deserialize<List<Book>>(json);
        books = loadedBooks;
    }
}


