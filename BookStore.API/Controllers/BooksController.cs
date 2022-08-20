using BookStore.API.Data.Repositories.Implementations;
using BookStore.API.Exceptions;
using BookStore.API.Models;
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
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _books.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            return Ok(await _books.GetAsync(id));
        }

        /// <summary>
        /// Купить книгу с указанным Id
        /// </summary>
        /// <param name="id">Id книги (<see cref="Book"/>)</param>
        /// <returns></returns>
        /// <response code="200">If the book was bought.</response>
        /// <response code="404">If the book with the given <param name="id"></param> was not found.</response>
        [HttpPost("{id:int}")]
        public async Task<IActionResult> BuyAsync(int id)
        {
            try
            {
                await _books.BuyAsync(id);

                return Ok($"The book with id = {id} was bought!");
            }
            catch (DbException ex)
            {
                return NotFound($@"Book with id = {id} wasn't found, possibly was bought already by someone else."
#if DEBUG
                                + $"Exception message: {ex.Message}"
#endif
                    );
            }
        }

        [HttpPost]
        // TODO: RequestParameters instead of Book model... Because BindRequired obliges to have Id specified
        public async Task<IActionResult> AddNewAsync([BindRequired, FromBody] Book book)
        {
            try
            {
                await _books.AddAsync(book);
                return CreatedAtAction(nameof(GetAsync), new {id = book.Id}, book);
            }
            catch (DbException ex)
            {
                return BadRequest(
                    $"Failed to add book '{book.Title}' by {book.Author} to database, possibly already exists.");
            }
        }
    }
}