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
        public static List<Club> Clubs = GetClubList();
        //Method to Display Clubs
        public static List<Club> GetClubList()
        {
            string path = @"..\..\..\TextFiles\Clubs.txt";
            StreamReader reader = new StreamReader(path);

            List<Club> clubList = new List<Club>();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] splitClub = line.Split(",");
                clubList.Add(new Club(splitClub[0], splitClub[1]));
            }
            reader.Close();
            return clubList;
        }

        public static void PrintClubList(List<Club> clubs)
        {
            int count = 0;
            Console.WriteLine("Here are our locations:");
            clubs.ForEach(club => Console.WriteLine($"({++count}) {club.Name} - {club.Address}"));
        }

        // Method to Read SingleClubMembers Text File and build list
        public static List<SingleClubMember> GetSingleClubMembers()
        {
            List<SingleClubMember> singleClubMembers = new List<SingleClubMember>();

            string path = @"..\..\..\TextFiles\SingleClubMembers.txt";
            StreamReader reader = new StreamReader(path);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] splitMember = line.Split(",");
                singleClubMembers.Add(new SingleClubMember(int.Parse(splitMember[0]), splitMember[1], splitMember[2]));
            }
            reader.Close();

            return singleClubMembers;
        }

        // Method to Read MultiClubMembers Text File and build list
        public static List<MultiClubMember> GetMultiClubMembers()
        {
            List<MultiClubMember> multiClubMembers = new List<MultiClubMember>();

            string path = @"..\..\..\TextFiles\MultiClubMembers.txt";
            StreamReader reader = new StreamReader(path);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] splitMember = line.Split(",");
                multiClubMembers.Add(new MultiClubMember(int.Parse(splitMember[0]), splitMember[1], int.Parse(splitMember[2])));
            }
            reader.Close();

            return multiClubMembers;
        }

        // Writes SingleClubMembers list to text file
        public static void WriteSingleClubMembers(List<SingleClubMember> singleClubMembers)
        {
            string path = @"..\..\..\TextFiles\SingleClubMembers.txt";
            StreamWriter writer = new StreamWriter(path);

            foreach (var member in singleClubMembers)
            {
                writer.WriteLine($"{member.Id},{member.Name},{member.NameOfClub}");
            }

            writer.Close();
        }

        // Writes MultiClubMembers list to text file
        public static void WriteMultiClubMembers(List<MultiClubMember> multiClubMembers)
        {
            string path = @"..\..\..\TextFiles\MultiClubMembers.txt";
            StreamWriter writer = new StreamWriter(path);

            foreach (var member in multiClubMembers)
            {
                writer.WriteLine($"{member.Id},{member.Name},{member.MemberPoints}");
            }

            writer.Close();
        }

        //Method to add multi-club members
        public static void AddMultiMember(List<MultiClubMember> members)
        {
            Console.Clear();
            Console.Write("What ID number should be assigned? ");
            int Id = int.Parse(Console.ReadLine());
            Console.Write("Please enter your name? ");
            string name = Console.ReadLine();
            members.Add(new MultiClubMember(Id, name, 0));
            Console.Clear();
            ShowSimplePercentage();
            Console.WriteLine($"\nCongrats, {name}! You're ready to start your fitness journey!\nHere is your bill due today:");
            members[members.Count - 1].GenerateBill();
        }

        //Method to add single club members
        public static void AddSingleMember(List<SingleClubMember> members, List<Club> clubs1)
        {
            Console.WriteLine();
            Console.Write("What location would you like to join (1-4)? ");
            int location = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("What ID number should be assigned? ");
            int Id = int.Parse(Console.ReadLine());
            Console.Write("Please enter your name? ");
            string name = Console.ReadLine();
            members.Add(new SingleClubMember(Id, name, clubs1[location - 1].Name));
            Console.Clear();
            ShowSimplePercentage();
            Console.WriteLine($"\nCongrats, {name}! You're ready to start your fitness journey!\nHere is your bill due today:");
            members[members.Count - 1].GenerateBill();
        }

        //Method to remove members multi-club members
        public static void RemoveMember(List<MultiClubMember> multiMembers, List<SingleClubMember> singleMembers)
        {
            Console.WriteLine("Sorry to see you go.");
            Console.WriteLine("What is your name?");
            string usersName = Console.ReadLine().ToLower();
            int singleMembersIndex = singleMembers.FindIndex(member => member.Name.ToLower() == usersName);
            int multiMembersIndex = multiMembers.FindIndex(member => member.Name.ToLower() == usersName);
            if (singleMembersIndex != -1)
            {
                Console.Clear();
                singleMembers.RemoveAt(singleMembersIndex);
                Console.WriteLine($"{usersName} has canceled their membership.");
                WriteSingleClubMembers(singleMembers);
            }
            else if (multiMembersIndex != -1)
            {
                Console.Clear();
                multiMembers.RemoveAt(multiMembersIndex);
                Console.WriteLine($"{usersName} has canceled their premium membership.");
                WriteMultiClubMembers(multiMembers);
            }
            else
                Console.WriteLine("Member not found!");
        }

        public static void PayBill(List<MultiClubMember>multiMembers, List<SingleClubMember> singleMembers)
        {
            Console.WriteLine("Ok! You're looking to pay your bill.");
            Console.WriteLine("What is your name?");
            string usersName = Console.ReadLine().ToLower();
            int singleMembersIndex = singleMembers.FindIndex(member => member.Name.ToLower() == usersName);
            int multiMembersIndex = multiMembers.FindIndex(member => member.Name.ToLower() == usersName);
            Console.WriteLine("\nHere's what we found:");

            if (singleMembersIndex != -1)
            {
                singleMembers[singleMembersIndex].GenerateBill();
            }
            else if (multiMembersIndex != -1)
            {
                multiMembers[multiMembersIndex].GenerateBill();

            }
            else
                Console.WriteLine("Member not found!");
        }

        public static void GetMemberInfo(List<MultiClubMember> multiMembers, List<SingleClubMember> singleMembers)
        {
            Console.WriteLine("What is your name?");
            string usersName = Console.ReadLine().ToLower();
            int singleMembersIndex = singleMembers.FindIndex(member => member.Name.ToLower() == usersName);
            int multiMembersIndex = multiMembers.FindIndex(member => member.Name.ToLower() == usersName);
            Console.WriteLine("\nHere is what we found:");

            if (singleMembersIndex != -1)
            {
                singleMembers[singleMembersIndex].DisplayMember();
            }
            else if (multiMembersIndex != -1)
            {
                multiMembers[multiMembersIndex].DisplayMember();

            }
            else
                Console.WriteLine("Member not found!");
        }

        public static int GetClubIndex(string clubName)
        {
            int clubIndex = Clubs.FindIndex(club => club.Name.ToLower() == clubName.ToLower());
            return clubIndex;
        }

        static void ShowSimplePercentage()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rProgress: {i}%   ");
                Thread.Sleep(25);
            }

            Console.Write("\rDone!          ");
        }
    }
}

    

