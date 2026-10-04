partial class Library
{
    public void AddMember(Member member)
    {
        foreach (Member existingmember in members)
        {
            if (existingmember.ID == member.ID)
            {
                Console.WriteLine("Member Already Exists");
                return;
            }
        }
        members.Add(member);
    }

    public void ViewMembers()
    {
        foreach (Member member in members)
        {
            Console.WriteLine(member.ID);
            Console.WriteLine(member.Name);
            Console.WriteLine(member.Email);
            Console.WriteLine();
        }
    }

    public Member UpdateMember()
    {
        Member member = SearchMember();

        if (member == null)
        {
            Console.WriteLine("Member Not Found");
            return null;
        }
        Console.WriteLine("What do you want to update?");
        Console.WriteLine("1. Name");
        Console.WriteLine("2. Email");

        int updatemember = GetUpdateMember();

        switch (updatemember)
        {
            case 1:
                Console.WriteLine();
                Console.WriteLine("Update Name Selected");

                string newname = GetMemberName();
                member.Name = newname;

                Console.WriteLine($"Member Name updated to: {member.Name}");

                break;

            case 2:

                Console.WriteLine();
                Console.WriteLine("Update Email Selected");

                string newemail = GetMemberEmail();
                member.Email = newemail;

                Console.WriteLine($"Member Email updated to: {member.Email}");

                break;
        }
        return member;
    }
    public void DeleteMember()
    {
        Member member = SearchMember();
        if (member == null)
        {
            Console.WriteLine("Member Not Found");
            return;
        }
        if (member.BorrowedBooks.Count > 0)
        {
            Console.WriteLine("Member has borrowed books.\r\nCannot delete member.");
            return;
        }
        members.Remove(member);
        Console.WriteLine("Member removed Successfully");

    }



}