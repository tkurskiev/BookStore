using BookStore.API.Data.Repositories.Implementations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

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
            return Ok(await _books.GetAllAsync());
        }

        [HttpDelete]
        public async Task<IActionResult> Buy([BindRequired, FromQuery] int id)
        {
            await _books.DeleteAsync(id);

            return Ok($"The book with id = {id} was bought!");
        }
    }
}