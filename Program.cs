﻿using FitnessCenterMidTerm.Classes;
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
while (continueProgram)
{

   
    Console.WriteLine("Hello! Welcome to Push It Fitness!\n");
    Console.WriteLine("Would you like to: \n(1) Join a club\n(2) Check in\n(3) Cancel membership\n(4) Pay your bill\n(0) to exit");

    switch (Console.ReadKey().Key)
    {
        case ConsoleKey.D1:
        case ConsoleKey.NumPad1:
            Console.Clear();
            Console.WriteLine("Here are our locations:");
            clubs.ForEach(club => Console.WriteLine($"{club.Name} - {club.Address}"));
            Console.WriteLine();
            Console.WriteLine("Would you like to: \n (1) Join a single club\n (2) Sign-up with our premium membership to have access to all locations");
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


            Console.ReadLine();
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
            Console.Clear();
            Console.WriteLine("Please enter a valid input!");
            break;

    }
}



    