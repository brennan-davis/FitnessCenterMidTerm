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

        // Property
        public Club ClubMembership { get; set; }
    }
}

