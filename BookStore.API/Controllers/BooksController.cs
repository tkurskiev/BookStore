using BookStore.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        public BooksController()
        {

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }
    }
}