public class Library
{
    private List<Book> books;
    private List<Member> members;
    private int totalBooks;
    private int totalMembers;

    public Library()
    {
        books = new List<Book>();
        members = new List<Member>();
        totalBooks = 0;
        totalMembers = 0;
    }

    public List<Member> GetMembers()
    {
        return members;
    }

    public int GetTotalBooksCount()
    {
        return totalBooks;
    }

    public int GetTotalMembersCount()
    {
        return totalMembers;
    }

    public void AddBook(Book book)
    {
        books.Add(book);
        totalBooks++;
        Console.WriteLine($"Book '{book.GetTitle()}' is added to the Library");
    }

    public void RemoveBook(int bookId)
    {
        Book bookToRemove = books.FirstOrDefault(book => book.GetBookId() == bookId);
        if(bookToRemove != null)
        {
            books.Remove(bookToRemove);
            totalBooks--;
            Console.WriteLine($"Book '{bookToRemove.GetTitle()}' is removed from the Library");
        }
        else
        {
            Console.WriteLine($"Book ID {bookId} is not found in the Library");
        }
    }

    public void RegisterMember(Member member)
    {
        members.Add(member);
        totalMembers++;
        Console.WriteLine($"Member '{member.GetName()}' is registered to the Library");
    }

    public void RemoveMember(int memberId)
    {
        Member memberToRemove = members.FirstOrDefault(member => member.GetMemberID() == memberId);
        if(memberToRemove != null)
        {
            members.Remove(memberToRemove);
            totalMembers--;
            Console.WriteLine($"Member '{memberToRemove.GetName()}' is removed from the Library");
        }
        else
        {
            Console.WriteLine($"Member ID {memberId} is not found in the Library");
        }
    }

    public void LendBook(int bookId, int memberId)
    {
        Book bookToLend = null;
        Member memberToLend = null;

        //find the book to lend from the library
        foreach(var book in books)
        {
            if(book.GetBookId() == bookId)
            {
                bookToLend = book;
                break;
            }
        }

        //find the member to lend book from the library
        foreach(var member in members)
        {
            if(member.GetMemberID() == memberId)
            {
                memberToLend = member;
                break;
            }
        }

        if(bookToLend != null && memberToLend != null)
        {
            bool checkBookAvailability = memberToLend.BorrowBook(bookToLend, out bool checkBorrowLimitExceeded);
            if(checkBookAvailability && !checkBorrowLimitExceeded)
            {
                bookToLend.SetAvailability(false);
                Console.WriteLine($"Book '{bookToLend.GetTitle()}' is lent to member '{memberToLend.GetName()}' from the Library");
            }
            else if(checkBorrowLimitExceeded)
            {
                Console.WriteLine("Member has reached the borrowing limit of 3 books.");
            }
            else
            {
                Console.WriteLine($"The book {bookToLend.GetTitle()} is not available for borrowing.");
            }
        }
        else
        {
            Console.WriteLine("Either the book or the member does not exist in the Library");
        }
    }

    public void ReceiveBook(int bookId, int memberId)
    {
        Book bookToReceive = null;
        Member memberToReceive = null;

        //find the book in library
        foreach(var book in books)
        {
            if(book.GetBookId() == bookId)
            {
                bookToReceive = book;
                break;
            }
        }

        //find the member in the library
        foreach(var member in members)
        {
            if(member.GetMemberID() == memberId)
            {
                memberToReceive = member;
                break;
            }
        }

        if(bookToReceive != null && memberToReceive!= null)
        {
            memberToReceive.ReturnBook(bookToReceive);
            bookToReceive.SetAvailability(true);
            Console.WriteLine($"Book '{bookToReceive.GetTitle()}' is received from the member '{memberToReceive.GetName()}' to the Library");
        }
        else
        {
            Console.WriteLine("Either the book or the member does not exist in the Library");
        }
    }

    

    public void ShowAvailableBooks()
    {
        foreach(var book in books)
        {
            if(book.GetAvailability())
            {
                //Console.WriteLine($"Book ID: {book.GetBookId()}, Title: {book.GetTitle()}, Author: {book.GetAuthor()}");
                book.DisplayBookDetails();
            }
        }
    }

    public void ShowAllBooks()
    {
        foreach(var book in books)
        {
            Console.WriteLine($"Book ID: {book.GetBookId()}, Title: {book.GetTitle()}, Author: {book.GetAuthor()}");
        }
    }

    public void ShowAllMembers()
    {
        foreach(var member in members)
        {
            member.DisplayMemberDetails();
        }
    }
}