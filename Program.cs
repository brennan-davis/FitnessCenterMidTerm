﻿using FitnessCenterMidTerm.Classes;
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

Admin.AddMultiMember(multiClubMembers, new MultiClubMember(6, "Joe"));

multiClubMembers.ForEach(member => Console.WriteLine(member.ToString()));

MultiClubMember John = new MultiClubMember(6, "John");
Admin.AddMultiMember(multiClubMembers, John);

multiClubMembers.ForEach(member => Console.WriteLine(member.ToString()));

Admin.RemoveSingleMember(singleClubMembers, 2);

singleClubMembers.ForEach(member => member.GenerateBill());

multiClubMembers.ForEach(member => member.GenerateBill());



