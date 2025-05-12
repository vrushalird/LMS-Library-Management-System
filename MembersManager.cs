public class MembersManager
{
    private readonly Library _library;
    private readonly MenuManager _menumanager;

    public MembersManager(Library library)
    {
        _library = library;
        _menumanager = new MenuManager();
    }

    public int ManageMembers()
    {
        int option;
        do
        {
            option = _menumanager.DisplayMemberMenu();

            switch(option)
            {
                case 1: AddMember();
                        break;
                case 2: RemoveMember();
                        break;
                case 3: _library.ShowAllMembers();
                        break;
                case 4: Console.WriteLine();
                        Console.WriteLine("Exiting Member Management...");
                        break;
                case 5: Console.WriteLine();
                        Console.WriteLine($"Exiting the system... Goodbye {GlobalVariables.Name}!");
                        break;
                default:Console.WriteLine("Invalid option. Please try again.");
                        break;
            }
        }while(option != 4 && option!= 5);
        return option;
    }

    public void AddMember()
    {
        Console.WriteLine();
        Console.WriteLine("Please enter below details to add a member: ");
        Console.Write("Member Name: ");
        string name = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Phone: ");
        string phone = Console.ReadLine();
        //Console.Write("Member ID: ");
        //int memberId = int.Parse(Console.ReadLine());

        Console.WriteLine("Registering member to the Library......");

        Member member = new Member(name, email, phone, new List<Book>());
        _library.RegisterMember(member); //association between Library and Member
    }

    public void RemoveMember()
    {
        Console.WriteLine();
        Console.Write("Please enter the member ID of the member to remove: ");
        int memberId = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Removing member from the Library......");

        _library.RemoveMember(memberId);
    }
}