using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenterMidTerm.Classes
{
    public static class Admin
    {
        //methods

        //Method to Display Clubs
        public static List<Club> GetClubList()
        {
            List<Club> clubList = new List<Club>();
            clubList.Add(new Club("Houston","4614 Nasa Pkwy - Houston, TX"));
            clubList.Add(new Club("Boston","2225 Newbury St - Boston, MA"));
            clubList.Add(new Club("Chattanooga","2 Broad St - Chattanooga, TN"));
            clubList.Add(new Club("Colorado Springs","1 Olympic Plz - Colorado Springs, CO"));
            return clubList;
        }

        public static void PrintClubList(List<Club> clubs)
        {
            int count = 0;
            Console.WriteLine("Here are our locations:");
            clubs.ForEach(club => Console.WriteLine($"({++count}) {club.Name} - {club.Address}"));
        }

        //Method to add multi-club members
        public static void AddMultiMember(List<MultiClubMember> members)
        {
            Console.WriteLine();
            Console.Write("What ID number should be assigned? ");
            int Id = int.Parse(Console.ReadLine());
            Console.Write("Please enter your name? ");
            string name = Console.ReadLine();
            members.Add(new MultiClubMember(Id, name));
            Console.WriteLine();
            Console.WriteLine($"Congrats, {name}! You're ready to start your fitness journey!\nHere is your bill due today:");
            members[members.Count - 1].GenerateBill();
        }

        //Method to add single club members
        public static void AddSingleMember(List<SingleClubMember> members, List<Club> clubs1)
        {
            Console.WriteLine();
            Console.Write("What location would you like to join? ");
            int location = int.Parse(Console.ReadLine());
            Console.Write("What ID number should be assigned? ");
            int Id = int.Parse(Console.ReadLine());
            Console.Write("Please enter your name? ");
            string name = Console.ReadLine();
            members.Add(new SingleClubMember(Id, name, clubs1[location - 1]));
            Console.WriteLine();
            Console.WriteLine($"Congrats, {name}! You're ready to start your fitness journey!\nHere is your bill due today:");
            members[members.Count - 1].GenerateBill();
        }

        //Method to remove members multi-club members
        public static void RemoveMember(List<MultiClubMember> multiMembers, List<SingleClubMember> singleMembers)
        {
            Console.WriteLine("Sorry to see you go.");
            Console.WriteLine("What is your name?");
            string usersName = Console.ReadLine();
            int singleMembersIndex = singleMembers.FindIndex(member => member.Name == usersName);
            int multiMembersIndex = multiMembers.FindIndex(member => member.Name == usersName);
            if (singleMembersIndex != -1)
            {
                singleMembers.RemoveAt(singleMembersIndex);
                Console.WriteLine($"{usersName} has canceled their membership.");
            }
            else if (multiMembersIndex != -1)
            {
                multiMembers.RemoveAt(multiMembersIndex);
                Console.WriteLine($"{usersName} has canceled their Premium membership.");
            }
            else
                Console.WriteLine("Member not found!");
        }

    }
}

    

