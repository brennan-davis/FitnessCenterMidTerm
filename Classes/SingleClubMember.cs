using System;
namespace FitnessCenterMidTerm.Classes
{
    public class SingleClubMember : Member
    {
        public SingleClubMember(int id, string name, Club clubMembership)
        {
            Id = int.Parse($"{id}1");
            Name = name;
            ClubMembership = clubMembership;
            Fees = 9.99m;
        }
        public override void CheckIn(Club club)
        {

            if (ClubMembership == club)
            {
                Console.WriteLine($"Welcome {Name}");
            }

            else
            {
                Console.WriteLine(new Exception("You are currently not a member of this club. Would you like to join?").Message);
            }
        }

        public override string ToString()
        {
            string a = String.Format("{0,-10} {1, -10}", "ID:", $"{Id}");
            string b = String.Format("\n{0,-10} {1, -10}", "Name:", $"{Name}");
            string c = String.Format("\n{0,-10} {1, -10}", "Club:", $"{ClubMembership.Name}");
            return a + b + c + "\n";
        }

        public override void GenerateBill()
        {
            Console.WriteLine($"\nPush It Fitness\nClub Membership: {ClubMembership.Name}\nTotal Bill Due: {Fees.ToString("C")}");
        }

        // Property
        public Club ClubMembership { get; set; }


    }
}

