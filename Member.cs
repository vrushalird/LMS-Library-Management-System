public class Member
{
    private static int nextId = 1;
    private int memberId;
    private string name;
    private string email;
    private string phoneNumber;
    protected List<Book> borrowedBooks; //changed to protected to allow access in derived class

    // Constructor to initialize member details
    public Member(string name, string email, string phoneNumber, List<Book> borrowedBooks)
    {
        memberId = nextId++;
        this.name = name;
        this.email = email;
        this.phoneNumber = phoneNumber;
        this.borrowedBooks = borrowedBooks;
    }
    
    // Default constructor
    public Member()
    {
        memberId = nextId++;
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
    public virtual bool BorrowBook(Book book, out bool checkBorrowLimitExceeded) //marked as virtual to override in derived class
    {
        bool checkAvailability = true;
        checkBorrowLimitExceeded = false;
        if (book.GetAvailability())
        {
            if(GetBorrowedBooksCount() < 3)
            {
                borrowedBooks.Add(book);
                book.Borrow();
                //Console.WriteLine($"Member {name} borrowed the book: {book.GetTitle()}");
            }
            else
            {
                checkBorrowLimitExceeded = true;
                //Console.WriteLine("Member has reached the borrowing limit of 3 books.");
            }
        }
        else
        {
            checkAvailability = false;
            //Console.WriteLine($"The book {book.GetTitle()} is not available for borrowing.");
        }
        return checkAvailability;
    }

    //helper method for getting borrowed books count
    public int GetBorrowedBooksCount()
    {
        return borrowedBooks.Count;
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