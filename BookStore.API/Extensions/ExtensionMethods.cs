using BookStore.API.Contracts.Requests;
using BookStore.API.Contracts.Responses;
using BookStore.API.Models;

namespace BookStore.API.Extensions
{
    public static class ExtensionMethods
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

        public static Book ToBook(this AddNewRequest request)
        {
            return new Book
            {
                Author = request.Author,
                Title = request.Title,
                PublicationDate = request.PublicationDate
            };
        }
    }
}
