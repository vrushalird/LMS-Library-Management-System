public class Book
{
    private int bookId;
    private string title;
    private string author;
    private bool isAvailable;

    // Constructor to initialize book details
    public Book(int id, string title, string author, bool isAvailable)
    {
        bookId = id;
        this.title = title;
        this.author = author;
        this.isAvailable = isAvailable;
    }
    
    // Default constructor
    public Book()
    {
        bookId = 0;
        title = "Unknown";
        author = "Unknown";
        isAvailable = true;
    }

    // Getters for book details
    public int GetBookId()
    {
        return bookId;
    }

    public string GetTitle()
    {
        return title;
    }

    public string GetAuthor()
    {
        return author;
    }

    public bool GetAvailability()
    {
        return isAvailable;
    }

    // Setters for book details
    public void SetBookId(int id)
    {
        bookId = id;
    }

    public void SetTitle(string title)
    {
        this.title = title;
    }

    public void SetAuthor(string author)
    {
        this.author = author;
    }

    public void SetAvailability(bool isAvailable)
    {
        this.isAvailable = isAvailable;
    }


    //method for borrowing a book
    public void Borrow()
    {
        isAvailable = false;
        Console.WriteLine($"Below book is borrowed:\nTitle: {title}, Author: {author}");  
    }

    //method for returning a book
    public void ReturnBook()
    {
        isAvailable = true;
        Console.WriteLine($"Below book is returned:\nTitle: {title}, Author: {author}");
    }

    //method for displaying book details
    public void DisplayBookDetails()
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine($"Book ID: {bookId}\nTitle: {title}\nAuthor: {author}\nAvailability: {isAvailable}");
        Console.WriteLine("--------------------------------------------");
    }
}