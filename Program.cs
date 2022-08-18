using FitnessCenterMidTerm.Classes;
using System.Runtime.CompilerServices;

List<Club> clubs = Admin.GetClubList();
List<SingleClubMember> singleClubMembers = new List<SingleClubMember>()
{
    new SingleClubMember(2,"Lisa", clubs[0]),
    new SingleClubMember(3, "Tolu", clubs[1])
};

List<MultiClubMember> multiClubMembers = new List<MultiClubMember>()
{
    new MultiClubMember(4,"Brennan"),
    new MultiClubMember(5, "Morgan")
};

bool continueProgram = true;

Console.WriteLine("Hello! Welcome to Push It Fitness!\n");
while (continueProgram)
{
    Console.WriteLine("Would you like to: \n(1) Join a club\n(2) Check in\n(3) Cancel membership\n(4) Pay your bill\n(0) to exit");

    switch (Console.ReadKey().Key)
    {
        #region JoinClub
        case ConsoleKey.D1:
        case ConsoleKey.NumPad1:
            Console.Clear();
            Admin.PrintClubList(clubs);
            Console.WriteLine();
            Console.WriteLine("Would you like to: \n(1) Join a single club\n(2) Sign-up with our premium membership to have access to all locations");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Admin.AddSingleMember(singleClubMembers, clubs);
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Admin.AddMultiMember(multiClubMembers);
                    break;
                default:
                    Console.WriteLine("You've chosen not to join. Goodbye.");
                    break;
            }
            Console.WriteLine("\nWould you like to return to the main menu? (Press Y)");
            if(Console.ReadKey().Key != ConsoleKey.Y)
                continueProgram = false;
            Console.Clear();
            break;
        #endregion

        #region CheckIn
        case ConsoleKey.D2:
        case ConsoleKey.NumPad2:
            Console.Clear();
            Console.WriteLine("Checking in! What is your name?");
            var usersName = Console.ReadLine();
            Console.WriteLine();
            List<SingleClubMember> filteredSingleMembers = singleClubMembers.Where(x => x.Name.Equals(usersName)).ToList();
            List<MultiClubMember> filteredMultiMembers = multiClubMembers.Where(x => x.Name.Equals(usersName)).ToList();
            Admin.PrintClubList(clubs);
            Console.Write("\nWhich club would you like to check into? ");
            int clubLocation = int.Parse(Console.ReadLine());
            if (filteredSingleMembers.Count == 1)
                filteredSingleMembers[0].CheckIn(clubs[clubLocation - 1]);
            else if (filteredMultiMembers.Count == 1)
                filteredMultiMembers[0].CheckIn(clubs[clubLocation - 1]);
            Console.WriteLine("\nWould you like to return to the main menu? (Press Y)");
            if (Console.ReadKey().Key != ConsoleKey.Y)
                continueProgram = false;
            Console.Clear();
            break;
        #endregion

        case ConsoleKey.D3:
        case ConsoleKey.NumPad3:
            Console.Clear();
            Admin.RemoveMember(multiClubMembers, singleClubMembers);
            Console.WriteLine("\nWould you like to return to the main menu? (Press Y)");
            if (Console.ReadKey().Key != ConsoleKey.Y)
                continueProgram = false;
            Console.Clear();

            break;
        case ConsoleKey.D4:
        case ConsoleKey.NumPad4:
            Console.WriteLine("");
            break;
        case ConsoleKey.D0:
        case ConsoleKey.NumPad0:
            continueProgram = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Please enter a valid input!");
            break;

    }
}



    