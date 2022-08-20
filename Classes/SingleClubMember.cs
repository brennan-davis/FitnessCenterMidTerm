using System;
namespace FitnessCenterMidTerm.Classes
{
    public class SingleClubMember : Member
    {
        public SingleClubMember(int id, string name, string nameOfClub)
        {
            Id = id;
            Name = name;
            NameOfClub = nameOfClub;
            Fees = 9.99m;
        }
        public override void CheckIn(Club club)
        {

            if (NameOfClub == club.Name)
            {
                Console.Clear();
                Console.WriteLine($"Welcome {Name}! You're ready to PUSH IT!");
            }

            else
            {
                Console.WriteLine(new Exception("You are currently not a member of this club.").Message);
            }
        }

        public override string ToString()
        {
            string a = String.Format("{0,-10} {1, -10}", "ID:", $"{Id}");
            string b = String.Format("\n{0,-10} {1, -10}", "Name:", $"{Name}");
            string c = String.Format("\n{0,-10} {1, -10}", "Club:", $"{NameOfClub}");
            return a + b + c + "\n";
        }

        public override void GenerateBill()
        {
            Console.WriteLine($"\nPush It Fitness\nClub Membership: {NameOfClub}\nTotal Bill Due: {Fees.ToString("C")}");
        }

        public override void DisplayMember()
        {
            Console.WriteLine($"\nPush It Fitness\nMembership ID: {Id}\nMember Name: {Name}\nClub Membership: {NameOfClub}\nClub Address: {Admin.Clubs[Admin.GetClubIndex(NameOfClub)].Address}\n");
        }

        // Property
        public string NameOfClub { get; set; }


    }
}

