namespace FitnessCenterMidTerm.Classes
{
    public abstract class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Fees { get; set; }

        public abstract void CheckIn(Club club);
        public abstract void GenerateBill();

    }
}
