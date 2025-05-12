using System;

namespace LibraryManagement
{
    internal class NewBaseType
    {
        
        static void Main(string[] args)
        {
            /*// Create an instance of the Book class
            Book book = new Book();

            book.SetBookId(1);
            book.SetTitle("The Great Gatsby");
            book.SetAuthor("F. Scott Fitzgerald");
            book.SetAvailability(true);

            // Display book details
            book.DisplayBookDetails();

            
            // Borrow the book
            book.Borrow();
            book.DisplayBookDetails();

            // Return the book
            book.ReturnBook();
            book.DisplayBookDetails();
            

            // Create an instance of the Member class
            Member member = new Member(101, "John Doe", "johndoe@email.com", "1234567890", new List<Book>());

            member.DisplayMemberDetails();
            */


            Console.Write("Please enter your member ID: ");
            GlobalVariables.MemberId = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Please enter your name: ");
            GlobalVariables.Name = Console.ReadLine();

            //Welcome Window
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Hello {GlobalVariables.Name}!");
            Console.WriteLine("============================================");
            Console.WriteLine(" Welcome to the Library Management System! ");
            Console.WriteLine("============================================");
            

            int option;
            int bookOption = 0;

            Library library = new Library();
            MenuManager menuManager = new MenuManager();

            do
            {
                
                option = menuManager.DisplayMainMenu();

                switch (option)
                {
                    case 1:
                        // Book Management
                        if(GlobalVariables.Name == "admin" && GlobalVariables.MemberId == 10001)
                        {
                            BooksManager booksManager = new BooksManager(library);
                            booksManager.ManageBooks();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you don't have the permissions to access Book Management!");
                        }
                        break;
                    case 2:
                        // Member Management
                        if(GlobalVariables.Name == "admin" && GlobalVariables.MemberId == 10001)
                        {
                            MembersManager membersManager = new MembersManager(library);
                            membersManager.ManageMembers();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you don't have the permissions to access Member Management!");
                        }
                        break;
                    case 3:
                        // Library Management
                        LibraryManager libraryManager = new LibraryManager(library);
                        libraryManager.ManageLibrary();
                        break;
                    case 4:
                        // Exit
                        Console.WriteLine($"Exiting the system... Goodbye {GlobalVariables.Name}!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

            }while(option != 4);   
        }
    }

}
