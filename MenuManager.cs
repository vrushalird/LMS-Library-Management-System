public class MenuManager
{
    public int DisplayMainMenu()
    {
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("|              Main Menu Options             |");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("1. Go To Book Management");
        Console.WriteLine("2. Go To Member Management");
        Console.WriteLine("3. Go To Library Management");
        Console.WriteLine("4. Exit");
        Console.WriteLine("---------------------------------------------");
        Console.Write("Please select an option: ");
        int option = int.Parse(Console.ReadLine());
        Console.WriteLine();
        return option;
    }

    public int DisplayBookMenu()
    {
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("|          Book Management Options           |");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("1. Add a new Book");
        Console.WriteLine("2. Remove a Book");
        Console.WriteLine("3. Show Available Books");
        Console.WriteLine("4. Show All Books");
        Console.WriteLine("5. Back to Main Menu");
        Console.WriteLine("6. Exit");
        Console.WriteLine("---------------------------------------------");
        Console.Write("Please select an option: ");
        return int.Parse(Console.ReadLine());
    }

    public int DisplayMemberMenu()
    {
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("|         Member Management Options          |");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("1. Add a new Member");
        Console.WriteLine("2. Remove a Member");
        Console.WriteLine("3. Show All Registered Members");
        Console.WriteLine("4. Back to Main Menu");
        Console.WriteLine("5. Exit");
        Console.WriteLine("---------------------------------------------");
        Console.Write("Please select an option: ");
        return int.Parse(Console.ReadLine());
    }

    public int DisplayLibraryMenu()
    {
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("|         Library Management Options         |");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("1. Lend a Book to a new Member");
        Console.WriteLine("2. Return a Book");
        Console.WriteLine("3. View borrowed Books per Member");
        Console.WriteLine("4. View total count of Books");
        Console.WriteLine("5. View total count of Members");
        Console.WriteLine("6. Back to Main Menu");
        Console.WriteLine("7. Exit");
        Console.WriteLine("---------------------------------------------");
        Console.Write("Please select an option: ");
        return int.Parse(Console.ReadLine());
    }
}