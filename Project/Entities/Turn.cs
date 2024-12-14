namespace Project.Entities
{
    public class Turn
    {
        public string TurnId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
    }
}
