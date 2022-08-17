using FitnessCenterMidTerm.Classes;
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

Console.WriteLine("Hello! Welcome to Push It Fitness!");
Console.WriteLine("Would you like to (1) Join a club, (2) Check in, (3) Cancel membership, (4) Pay your bill, or (0) to exit");

switch (Console.ReadKey().Key)
{
    case ConsoleKey.D1:
    case ConsoleKey.NumPad1: 
        Console.WriteLine("Would you like to join a single club or signup with our premium membership to have access to all locations?");
        break;
    case ConsoleKey.D2:
    case ConsoleKey.NumPad2:
        Console.WriteLine("");
        break;
    case ConsoleKey.D3:
    case ConsoleKey.NumPad3:
        Console.WriteLine("");
        break;
    case ConsoleKey.D4:
    case ConsoleKey.NumPad4:
        Console.WriteLine("");
        break;
    case ConsoleKey.D0:
    case ConsoleKey.NumPad0:
        Console.WriteLine("");
        break;
    default: 
        Console.WriteLine("Please enter a valid input!");
        break;

}

    