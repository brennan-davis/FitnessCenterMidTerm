using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenterMidTerm.Classes
{
    public static class Admin
    {
        public static List<Club> GetClubList()
        {
            List<Club> clubList = new List<Club>();
            clubList.Add(new Club("Houston","4614 Nasa Pkwy - Houston, TX"));
            clubList.Add(new Club("Boston","2225 Newbury St - Boston, MA"));
            clubList.Add(new Club("Chattanooga","2 Broad St - Chattanooga, TN"));
            clubList.Add(new Club("Colorado Springs","1 Olympic Plz - Colorado Springs, CO"));
            return clubList;
        }

    }
}

    

