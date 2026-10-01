using System;

class Program 
{
    static void Main(string[] args) 
    {
        Library library = new Library();

        Book book1 = new Book(1, "Code With C#", "Mrs John", "Tech", true);
        Book book2 = new Book(2, "Python", "Mrs John", "Tech", true);
        Book book3 = new Book(3, "HTML", "Mrs John", "Tech", true);
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);
        library.ViewBooks();
        //foreach (Book book  in books) 
        //{
        //    Console.WriteLine(book.ID);
        //    Console.WriteLine(book.Title);
        //    Console.WriteLine(book.Author);
        //    Console.WriteLine(book.Category);
        //    Console.WriteLine(book.IsAvailable);
        //    Console.WriteLine();
        //}


        Member member1 = new Member(1, "Adan", "adan@gmail.com");
        Member member2 = new Member(2, "Ahmed", "ahmed@gmail.com");
        Member member3 = new Member(3, "Taha", "taha@gmail.com");
        library.AddMember(member1); 
        library.AddMember(member2); 
        library.AddMember(member3);
        library.ViewMembers();

        //foreach (Member member in members) 
        //{
        //    Console.WriteLine(member.ID);
        //    Console.WriteLine(member.Name);
        //    Console.WriteLine(member.Email);
        //    Console.WriteLine();
        //}
        Book bookresult = library.SearchBook();
                
        if (bookresult == null)
        {
            Console.WriteLine("Book Not Found");
        }
        else 
        {
            Console.WriteLine($"Book Found: \n{bookresult.Title} \n{bookresult.Author} \n{bookresult.Category} \n{bookresult.IsAvailable}"); 
        }

        library.BorrowBook();

        Member memberresults = library.SearchMember();

        if (memberresults == null)
        {
            Console.WriteLine("Member Not Found");
        }
        else
        {
            Console.WriteLine($"{memberresults.ID} : {memberresults.Name}");
        }

    }
}