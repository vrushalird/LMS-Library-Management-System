using System.Runtime.CompilerServices;

public class PremiumMember : Member
{
    private int borrowingLimit;

    //Constructor calling the base class constructor
    public PremiumMember(string name, string email, string phoneNo, List<Book> borrowedBooks, int borrowingLimit) 
        : base(name, email, phoneNo, borrowedBooks)
    {
        this.borrowingLimit = borrowingLimit;
    }

    //default constructor
    public PremiumMember() : base()
    {
        borrowingLimit = 10;
    }

    public override bool BorrowBook(Book book, out bool checkBorrowLimitExceeded)
    {
        bool checkAvailability = true;
        checkBorrowLimitExceeded = false;
        if(GetBorrowedBooksCount() < borrowingLimit)
        {
            //calling base class method which uses default borrow limit
            checkAvailability = base.BorrowBook(book, out checkBorrowLimitExceeded);
            //check if borrow limit of premium member exceeded
            if(checkBorrowLimitExceeded)
            {
                if(GetBorrowedBooksCount() < borrowingLimit)
                {
                    borrowedBooks.Add(book);
                    book.Borrow();
                }
                else
                {
                    checkBorrowLimitExceeded = true;
                }   
            }
        }
        else
        {
            Console.WriteLine($"Premium member {GetName()} has reached the borrowing limit of {GetBorrowedBooksCount()} books.");
        }
        return checkAvailability;
    }

}