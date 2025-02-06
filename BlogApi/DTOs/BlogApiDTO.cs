namespace Controllers.DTOs
{
    public class BlogApiDTO
    {
        public required string Title { get; set; }
        public required string Content { get; set; }
        public required string Author { get; set; }
        public required string ImageUrl { get; set; }
        public string CreatedDate { get; set; } = DateTime.Now.ToString("yyyy-MM-dd"); // Default to current date
        public string CreatedTime { get; set; } = DateTime.Now.ToString("HH:mm:ss"); // Default to current time
    }
}