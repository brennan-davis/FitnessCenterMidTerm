﻿namespace FitnessCenterMidTerm.Classes
{
    public abstract class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public abstract void CheckIn();
    }
}
