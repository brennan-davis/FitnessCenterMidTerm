using System;
namespace FitnessCenterMidTerm.Classes
{
    public class Club
    {
        public Club(string name, string address)
        {
            Name = name;
            Address = address;
        }

        //Properties
        public string Name { get; set; }
        public string Address { get; set; }

       
    }
}

