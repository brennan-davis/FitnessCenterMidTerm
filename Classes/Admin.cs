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

        //Method to add multi-club members
        public static void AddMultiMember(List<MultiClubMember> members, MultiClubMember member)
        {
            members.Add(member);
        }

        //Method to add single club members
        public static void AddSingleMember(List<SingleClubMember> members, SingleClubMember member)
        {
            members.Add(member);
        }

        //Method to remove members multi-club members
        public static void RemoveMultiMember(List<MultiClubMember> members, int input)
        {
            members.RemoveAt(input - 1);
        }

        //Method to remove members single club members
        public static void RemoveSingleMember(List<SingleClubMember> members, int input)
        {
            members.RemoveAt(input - 1);
        }

    }
}

    

