public class LibraryManager
{
    private readonly Library _library;
    private readonly MenuManager _menuManager;

    public LibraryManager(Library library)
    {
        _library = library;
        _menuManager = new MenuManager();
    }

    public int ManageLibrary()
    {
        int option;
        do
        {
            option = _menuManager.DisplayLibraryMenu();

            switch(option)
            {
                case 1: LendBookToMember();
                        break;
                case 2: ReturnBookFromMember();
                        break;
                case 3: ViewBorrowedBooksPerMember();
                        break;
                case 4: Console.WriteLine($"Total Number of Books: {_library.GetTotalBooksCount()}");
                        break;
                case 5: Console.WriteLine($"Total Number of Members: {_library.GetTotalMembersCount()}");
                        break;
                case 6: Console.WriteLine();
                        Console.WriteLine("Exiting Library Management...");
                        break;
                case 7: Console.WriteLine();
                        Console.WriteLine($"Exiting the system... Goodbye {GlobalVariables.Name}!");
                        break;
                default:Console.WriteLine("Invalid option. Please try again.");
                        break;
            }
        }while(option != 6 && option != 7);
        return option;
    }

    public void LendBookToMember()
    {
        Console.WriteLine();
        Console.Write("Please enter the Book ID: ");
        int bookId = int.Parse(Console.ReadLine());
        Console.Write("Please enter the Member ID: ");
        int memberId = int.Parse(Console.ReadLine());

        Console.WriteLine("Lending book to the member......");

        _library.LendBook(bookId, memberId);
    }

    public void ReturnBookFromMember()
    {
        Console.WriteLine();
        Console.Write("Please enter the Book ID: ");
        int bookId = int.Parse(Console.ReadLine());
        Console.Write("Please enter the Member ID: ");
        int memberId = int.Parse(Console.ReadLine());

        Console.WriteLine("Returning book from the member......");

        _library.ReceiveBook(bookId, memberId);
    }

    public void ViewBorrowedBooksPerMember()
    {
        foreach(var member in _library.GetMembers())
        {
            Console.WriteLine($"Member: {member.GetName()},\nBorrowed Books: ");
            member.DisplayBorrowedBooks();
        }
    }
}