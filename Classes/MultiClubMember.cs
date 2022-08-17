﻿using System;
namespace FitnessCenterMidTerm.Classes
{
    public class MultiClubMember : Member
    {
        // Constructor
        public MultiClubMember(int id, string name)
        {
            Id = int.Parse($"{id}9");
            Name = name;
            MemberPoints = 0;
            Fees = 24.99m;
        }
        
        // Properties
        public int MemberPoints { get; set; }

        // Methods

        //Method to check in
        public override void CheckIn(Club club)
        {
            MemberPoints += 1;
            Console.WriteLine(MemberPoints);
        }

        public override void GenerateBill()
        {
            Console.WriteLine($"Push It Fitness\nPremium Member\nHello {Name}!" +
                $"\nTotal Bill Due: {Fees.ToString("C")}\nMember Points:{MemberPoints}");
        }
    

        //Method to display member info
        public override string ToString()
        {
            string a = String.Format("{0,-10} {1, -10}", "ID:", $"{Id}");
            string b = String.Format("\n{0,-10} {1, -10}", "Name:", $"{Name}");
            string c = String.Format("\n{0,-10} {1, -10}", "Club:", "All");
            string d = String.Format("\n{0,-10} {1, -10}", "Membership Points:", $"{MemberPoints}");
            return a + b + c + d + "\n";
        }
    }
}

