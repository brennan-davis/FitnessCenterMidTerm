using System;
namespace FitnessCenterMidTerm.Classes
{
    public class SingleClubMember : Member
    {
        public bool clubMembership { get; set; }

        public override void CheckIn(Club club)
        {

            if (clubMembership == true)
            {
                Console.WriteLine($"Welcome {Name}");
            }

            else
            {
                throw new Exception("You are currently not a member of this club.Would you like to join ?");
            }
        }
    }
}

