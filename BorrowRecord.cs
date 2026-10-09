class BorrowRecord
{
    public int BookID {  get; set; }
    public int MemberID { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime DueDate { get; set; }

    public BorrowRecord( int book, int member, DateTime borrowDate, DateTime dueDate) 
    {
        BookID = book;
        MemberID = member;
        BorrowDate = borrowDate;
        DueDate = dueDate;

    }

}