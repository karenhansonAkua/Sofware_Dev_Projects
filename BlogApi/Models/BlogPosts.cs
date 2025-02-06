using System;

namespace BlogApi.Models
{
    public class BlogPost
    {
        public Guid Id { get; set; } = Guid.NewGuid(); 
        public required string Title { get; set; }
        public required string Content { get; set; }
        public required string Author { get; set; }
        public required string ImageUrl { get; set; } // Link or path to the image
        public string CreatedDate { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");
        public string CreatedTime { get; set; } = DateTime.Now.ToString("HH:mm:ss");
    }
}