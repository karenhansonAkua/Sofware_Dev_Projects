namespace PracticeAPI.Models
{
    public class Prac
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Title { get; set; } 
        public string? Description { get; set; }
    }
}
