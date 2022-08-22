﻿using BookStore.API.Contracts.Requests;
using BookStore.API.Contracts.Responses;
using BookStore.API.Data.Repositories.Implementations;
using BookStore.API.Exceptions;
using BookStore.API.Extensions;
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
            var books = await _books.GetAllAsync();

            var booksResponse = books.Select(x => x.ToBookResponse());

            return Ok(new PagedResponse<BookResponse>(booksResponse));
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

                return CreatedAtAction(nameof(GetAsync).Replace("Async", ""), new {id = bookResponse.Id}, 
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