using BookStore.API.Data;
using BookStore.API.Data.Repositories.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly BookRepository _books;

        public BooksController(BookRepository books)
        {
            _books = books;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _books.GetAll());
        }
    }
}