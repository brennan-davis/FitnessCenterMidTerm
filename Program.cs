using FitnessCenterMidTerm.Classes;
List<Club> clubs = Admin.GetClubList();
List<SingleClubMember> singleClubMembers = new List<SingleClubMember>()
{
    new SingleClubMember(2,"Lisa", clubs[0])
};
Console.WriteLine(singleClubMembers[0].ClubMembership.Name);

singleClubMembers.ForEach(member => member.CheckIn(clubs[1]));
