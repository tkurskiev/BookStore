using BookStore.API.Contracts.Requests;
using BookStore.API.Contracts.Requests.Queries;
using BookStore.API.Contracts.Responses;
using BookStore.API.Data.Repositories.Implementations;
using BookStore.API.Data.Repositories.Interfaces;
using BookStore.API.Exceptions;
using BookStore.API.Extensions;
using BookStore.API.Helpers;
using BookStore.API.Models;
using BookStore.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BookStore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBooksRepository _books;
        private readonly IUriService _uriService;

        public BooksController(IBooksRepository books, IUriService uriService)
        {
            _books = books;
            _uriService = uriService;
        }

        /// <summary>
        /// Get all the books according to given filters
        /// </summary>
        /// <param name="allBooksQuery">Model with parameters for filtering the books.</param>
        /// <param name="paginationQuery">Model with parameters for paginating the response.</param>
        /// <response code="200">Returns 201 response with value of type: <see cref="PagedResponse{T}"/></response>
        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] GetAllBooksQuery allBooksQuery, [FromQuery] PaginationQuery paginationQuery)
        {
            var pagination = paginationQuery.ToPaginationFilter();
            var filter = allBooksQuery.ToGetAllBooksFilter();
            var books = await _books.GetAllAsync(filter, pagination);

            var booksResponse = books.Select(x => x.ToBookResponse()).ToList();

            if (pagination.PageNumber < 1 || pagination.PageSize < 1)
                return Ok(new PagedResponse<BookResponse>(booksResponse));

            var pagedResponse =
                PaginationHelpers.CreatePagedResponse(_uriService, pagination, booksResponse, Request.Path.ToString());

            return Ok(pagedResponse);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var book = await _books.GetAsync(id);

            if(book is null)
                return NotFound($"The book with the id = {id} was not found.");

            return Ok(new Response<BookResponse>(book.ToBookResponse()));
        }

        /// <summary>
        /// Buy a book with the given <paramref name="id"/>
        /// </summary>
        /// <param name="id">Id книги (<see cref="Book"/>)</param>
        /// <returns></returns>
        /// <response code="200">If the book was bought.</response>
        /// <response code="404">If the book with the given id was not found.</response>
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
        public async Task<IActionResult> AddNewAsync([BindRequired] AddNewRequest addNewBookRequest)
        {
            try
            {
                var savedBook = await _books.AddAsync(addNewBookRequest.ToBook());

                var bookResponse = savedBook.ToBookResponse();

                return CreatedAtAction(nameof(GetAsync).Replace("Async", ""),
                    new { id = bookResponse.Id },
                    new Response<BookResponse>(bookResponse));
            }
            catch (DbException ex)
            {
                return BadRequest(
                    $@"Failed to add book '{addNewBookRequest.Title}' by {addNewBookRequest.Author} to database, possibly already exists.
Error message: {ex.Message}");
            }
        }
    }
}