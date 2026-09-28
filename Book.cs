class Book
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Category { get; set; }
    public bool IsAvailable { get; set; }

    public Book(int id, string title, string author, string category, bool isAvailable)
    {
        ID = id;
        Title = title;
        Author = author;
        Category = category;
        IsAvailable = isAvailable;
    }
}
