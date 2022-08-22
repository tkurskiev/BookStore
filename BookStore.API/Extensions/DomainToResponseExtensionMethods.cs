using BookStore.API.Contracts.Responses;
using BookStore.API.Models;

namespace BookStore.API.Extensions
{
    public static class DomainToResponseExtensionMethods
    {
        public static BookResponse ToBookResponse(this Book book)
        {
            return new BookResponse
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                PublicationDate = book.PublicationDate
            };
        }
    }
}
