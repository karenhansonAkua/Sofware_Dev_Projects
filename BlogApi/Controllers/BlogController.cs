using Microsoft.AspNetCore.Mvc;
using BlogApi.Models;
using Controllers.DTOs;

namespace BlogApi.Controllers
{
    [Route("api/Blogs")]
    [ApiController]
    public class BlogPostsController : ControllerBase
    {
        private static List<BlogPost> _posts = new List<BlogPost>();

        //endpoint to crate a new post
        [HttpPost("createBlog")]

        public IActionResult createBlog(BlogApiDTO blogApiDTO)
        {
            {
                var blog = new BlogPost
                {
                    Title = blogApiDTO.Title,
                    Author = blogApiDTO.Author,
                    Content = blogApiDTO.Content,
                    ImageUrl = blogApiDTO.ImageUrl,
                    CreatedDate = blogApiDTO.CreatedDate,
                    CreatedTime = blogApiDTO.CreatedTime,
                };
                _posts.Add(blog);
                return Ok(blog);
            }
}
        // GET: api/blogposts
        [HttpGet ("allBlogs")]
        public IActionResult Getlist()
        {
            return Ok(_posts);
        }

        // GET: api/blogposts/{id}
        [HttpGet("{id}")]
        public IActionResult GetPost(Guid id) // Change to Guid
        {
            var post = _posts.FirstOrDefault(p => p.Id == id);
            if (post == null)
            {
                return NotFound();
            }
            return Ok(post);
        }

        

        // PUT api/blogposts/{id}
        [HttpPut("{id}")]
        public IActionResult UpdatePost(Guid id, BlogPost updatedPost) 
        {
            var post = _posts.FirstOrDefault(p => p.Id == id);
            if (post != null)
            {
                // Update the properties
                post.Title = updatedPost.Title;
                post.Content = updatedPost.Content;
                post.Author = updatedPost.Author;
                post.ImageUrl = updatedPost.ImageUrl;
                post.CreatedDate = updatedPost.CreatedDate;
                post.CreatedTime = updatedPost.CreatedTime;
                return NotFound();
            }

           

            return NoContent();
        }

        // DELETE all blog posts
        [HttpDelete("DeleteAll")]
        public IActionResult DeleteAll()
        {
            _posts.Clear(); // Clear all blog posts
            return NoContent();
        }

        //delete by id
        [HttpDelete("{id}")]

        public IActionResult DeleteBlog(Guid id)
        {
            var post = _posts.FirstOrDefault(t => t.Id == id);
            if (post != null)
            {
                _posts.Remove(post);
                return NoContent();
            }
            return NoContent();
        }
    }
}