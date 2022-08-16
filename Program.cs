using FitnessCenterMidTerm.Classes;
List<Club> clubs = Admin.GetClubList();
List<SingleClubMember> singleClubMembers = new List<SingleClubMember>()
{
    new SingleClubMember(2,"Lisa", clubs[0]),
    new SingleClubMember(3, "Tolu", clubs[1])
};
Console.WriteLine(singleClubMembers[0].ClubMembership.Name);

singleClubMembers.ForEach(member => member.CheckIn(clubs[1]));

List<MultiClubMember> multiClubMembers = new List<MultiClubMember>()
{
    new MultiClubMember(4,"Brennan"),
    new MultiClubMember(5, "Morgan")
};
Console.WriteLine(singleClubMembers[0].ClubMembership.Name);

multiClubMembers.ForEach(member => Console.WriteLine(member.ToString()));

