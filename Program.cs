using System;

class Book 
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Category { get; set; }
    public bool IsAvailable { get; set; }

    public Book(int id, string title, string author, string category, bool isavailable)
    {
        ID = id;
        Title = title;
        Author = author;
        Category = category;
        IsAvailable = isavailable;
    }
}

class Program 
{
    static void Main(string[] args) 
    {
        Book book = new Book(1, "Code With C#", "Mrs John", "Tech", true);
    
    }
}