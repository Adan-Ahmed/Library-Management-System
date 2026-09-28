using System;

class Program 
{
    static void Main(string[] args) 
    {
        List<Book> list = new List<Book>();
        Book book1 = new Book(1, "Code With C#", "Mrs John", "Tech", true);
        Book book2 = new Book(2, "Python", "Mrs John", "Tech", true);
        Book book3 = new Book(3, "HTML", "Mrs John", "Tech", true);
        list.Add(book2);
        list.Add(book3);
        list.Add(book1);

        foreach (Book book in list) 
        {
            Console.WriteLine(book.ID);
            Console.WriteLine(book.Title);
            Console.WriteLine(book.Author);
            Console.WriteLine(book.Category);
            Console.WriteLine(book.IsAvailable);
            Console.WriteLine();
        }

        List<Member>lists = new List<Member>();
        Member member1 = new Member(1, "Adan", "adan@gmail.com");
        Member member2 = new Member(2, "Ahmed", "ahmed@gmail.com");
        Member member3 = new Member(3, "Taha", "taha@gmail.com");
        lists.Add(member1); 
        lists.Add(member2); 
        lists.Add(member3);

        foreach (Member member in lists) 
        {
            Console.WriteLine(member.ID);
            Console.WriteLine(member.Name);
            Console.WriteLine(member.Email);
            Console.WriteLine();
        }

    
    }
}