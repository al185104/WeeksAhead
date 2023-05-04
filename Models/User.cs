namespace WeeksAhead.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public uint TargetAge { get; set; }
        public DateTime Birthday { get; set; }
    }
}
