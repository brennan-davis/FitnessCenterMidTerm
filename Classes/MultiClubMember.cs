using System;
namespace FitnessCenterMidTerm.Classes
{
    public class MultiClubMember : Member
    {
        // Constructor
        public MultiClubMember(int id, string name, int memberPoints)
        {
            Id = id;
            Name = name;
            MemberPoints = memberPoints;
            Fees = 24.99m;
        }
        
        // Properties
        public int MemberPoints { get; set; }

        // Methods

        //Method to check in
        public override void CheckIn(Club club)
        {
            MemberPoints += 1;
            Console.Clear();
            Console.WriteLine($"\nWelcome, {Name}! You're ready to PUSH IT!\nMembership Points Earned: {MemberPoints}");
        }

        public override void GenerateBill()
        {
            Console.WriteLine($"\nPush It Fitness\nPremium Member" +
                $"\nTotal Bill Due: {Fees.ToString("C")}\nMember Points: {MemberPoints}");
        }
        public override void DisplayMember()
        {
            Console.WriteLine($"\nPush It Fitness\nMembership ID: {Id}\nMember Name: {Name}\nMembership Points Earned: {MemberPoints}\nClub Membership: All locations!\n");
            Admin.PrintClubList(Admin.Clubs);
        }


        //Method to display member info
        public override string ToString()
        {
            string a = String.Format("{0,-10} {1, -10}", "ID:", $"{Id}");
            string b = String.Format("\n{0,-10} {1, -10}", "Name:", $"{Name}");
            string c = String.Format("\n{0,-10} {1, -10}", "Club:", "All");
            string d = String.Format("\n{0,-10} {1, -10}", "Membership Points:", $"{MemberPoints}");
            return a + b + c + d + "\n";
        }
    }
}

