using Microsoft.AspNetCore.Mvc;
using PracticeAPI.DTOs;
using PracticeAPI.Models;

namespace PracticeAPI.Controllers
{

    [ApiController]
    [Route("api/todos")]
    public class ToDoController : ControllerBase
    {//MVC-Model View Controller
        private static List<Prac> _PracList = new List<Prac>();

        //Endpoint to create a new todo 
        [HttpPost("createPrac")]
        public IActionResult createPrac(Request_DTO requestDTO)
        {
            var Todo = new Prac
            {
                Title = requestDTO.Title,
                Description = requestDTO.Description,
            };

            _PracList.Add(Todo);
            return Ok(Todo);
        }

        [HttpGet("allToDOs")]
        public IActionResult Getlist() {
            return Ok(_PracList);
                
                }

    }


}
