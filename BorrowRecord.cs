class BorrowRecord
{
    public Book Book {  get; set; }
    public Member Member { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime DueDate { get; set; }

    public BorrowRecord( Book book, Member member, DateTime borrowDate, DateTime dueDate) 
    {
        Book = book;
        Member = member;
        BorrowDate = borrowDate;
        DueDate = dueDate;
        
        //BorrowRecord borrowrecord = new BorrowRecord(book, member, DateTime.Now, DateTime.Now.AddDays(7);

    }

}