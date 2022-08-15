using System;
namespace FitnessCenterMidTerm.Classes
{
    public class MultiClubMember : Member
    {
        public MultiClubMember()
        {
            MemberCheckinPoints = 12;
        }

        public int MemberCheckinPoints { get; set; }

        public override void CheckIn(Club club)
        {
            int TotalMembershipPoints = 0;
            Console.WriteLine(TotalMembershipPoints += MemberCheckinPoints);
        }
    }
}

