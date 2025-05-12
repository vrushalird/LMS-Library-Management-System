public class BooksManager
{
    private readonly Library _library;
    private readonly MenuManager _menuManager;

    public BooksManager(Library library)
    {
        _library = library;
        _menuManager = new MenuManager();
    }

    public void ManageBooks()
    {
        int bookOption;
        do
        {
            bookOption = _menuManager.DisplayBookMenu();

            switch (bookOption)
            {
                case 1: AddBook();
                        break;
                case 2: RemoveBook();
                        break;
                case 3: Console.WriteLine();
                        _library.ShowAvailableBooks();
                        break;
                case 4: Console.WriteLine();
                        _library.ShowAllBooks();
                        break;
                case 5: Console.WriteLine();
                        Console.WriteLine($"Exiting Book Management...");
                        break;
                case 6: Console.WriteLine();
                        Console.WriteLine($"Exiting the system... Goodbye {GlobalVariables.Name}!");
                        break;
                default:Console.WriteLine();
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
            }
        }while(bookOption != 5 && bookOption != 6);
    }

    public void AddBook()
    {
        Console.WriteLine();
        Console.WriteLine("Please enter below details to add a book:");
        Console.Write("Book ID: ");
        int bookId = int.Parse(Console.ReadLine());
        Console.Write("Book Title: ");
        string title = Console.ReadLine();
        Console.Write("Author: ");
        string author = Console.ReadLine();
        Console.Write("Availability (true/false): ");
        bool isAvailable = bool.Parse(Console.ReadLine());
        
        Console.WriteLine();
        Console.WriteLine("Adding book in the Library......");

        Book book = new Book(bookId, title, author, isAvailable);
        _library.AddBook(book);
       
        //Console.WriteLine("Below book details are added:");
        //book.DisplayBookDetails();
    }

    public void RemoveBook()
    {
        Console.WriteLine();
        Console.Write("Please enter the Book ID of the book to remove: ");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Removing book from the Library......");

        _library.RemoveBook(id);
    }
}