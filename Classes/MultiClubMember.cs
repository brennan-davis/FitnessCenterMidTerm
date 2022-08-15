using System;
namespace FitnessCenterMidTerm.Classes
{
    public class MultiClubMember : Member
    {
        // Constructor
        public MultiClubMember(int id, string name)
        {
            Id = id;
            Name = name;
            MemberCheckinPoints = 0;
        }
        
        // Properties
        public int MemberCheckinPoints { get; set; }

        // Methods
        public override void CheckIn(Club club)
        {
            MemberCheckinPoints += 1;
            Console.WriteLine(MemberCheckinPoints);
        }
    }
}

