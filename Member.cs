class Member
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public List<Book> BorrowedBooks { get; set; } = new List<Book>();

    public Member(int id, string name, string email) 
    {
        ID = id;
        Name = name;
        Email = email;
    }
}