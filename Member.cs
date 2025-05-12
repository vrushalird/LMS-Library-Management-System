public class Member
{
    private int memberId;
    private string name;
    private string email;
    private string phoneNumber;
    private List<Book> borrowedBooks;

    // Constructor to initialize member details
    public Member(int id, string name, string email, string phoneNumber, List<Book> borrowedBooks)
    {
        memberId = id;
        this.name = name;
        this.email = email;
        this.phoneNumber = phoneNumber;
        this.borrowedBooks = borrowedBooks;
    }
    
    // Default constructor
    public Member()
    {
        memberId = 0;
        name = "Unknown";
        email = "Unknown";
        phoneNumber = "Unknown";
        borrowedBooks = new List<Book>();
    }

    public string GetName()
    {
        return name;
    }

    public int GetMemberID()
    {
        return memberId;
    }

    public void SetMemberId(int id)
    {
        memberId = id;
    }

    //method for borrowing a book
    public void BorrowBook(Book book)
    {
        if (book.GetAvailability())
        {
            borrowedBooks.Add(book);
            book.Borrow();
            Console.WriteLine($"Member {name} borrowed the book: {book.GetTitle()}");
        }
        else
        {
            Console.WriteLine($"The book {book.GetTitle()} is not available for borrowing.");
        }
    }

    //method for returning a book
    public void ReturnBook(Book book)
    {
        if (borrowedBooks.Contains(book))
        {
            borrowedBooks.Remove(book);
            book.ReturnBook();
            Console.WriteLine($"Member {name} returned the book: {book.GetTitle()}");
        }
        else
        {
            Console.WriteLine($"The book {book.GetTitle()} was not borrowed by member {name}.");
        }
    }

    //method for displaying member details
    public void DisplayMemberDetails()
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine($"Member ID: {memberId}\nName: {name}\nEmail: {email}\nPhone Number: {phoneNumber}");
        Console.WriteLine("Borrowed Books:");
        foreach (var book in borrowedBooks)
        {
            Console.WriteLine($"{book.GetTitle()} by {book.GetAuthor()}");
        }
        Console.WriteLine("--------------------------------------------");
    }

    public void DisplayBorrowedBooks()
    {
        Console.WriteLine("--------------------------------------------");
        foreach(var book in borrowedBooks)
        {
            Console.WriteLine($"{book.GetTitle()} by {book.GetAuthor()}");
        }
        Console.WriteLine("--------------------------------------------");
    }
}