using System.ComponentModel.DataAnnotations;
using BookStore.API.Contracts.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Contracts.Requests.Queries
{
    public class GetAllBooksQuery
    {
        [FromQuery(Name = "title")]
        public string? Title { get; set; }

        [FromQuery(Name = "author")]
        public string? Author { get; set; }

        [FromQuery(Name = "publicationDate")]
        [CheckDateTimeFormat(ErrorMessage =
            "The given value for publication date is in incorrect format, should be 'yyyy-MM-dd'.")]
        public string? PublicationDate { get; set; }

        [RegularExpression("author|title|publicationDate",
            ErrorMessage = "Invalid 'orderBy' parameter, should have one of the following values: author, title, publicationDate")]
        [FromQuery(Name = "orderBy")]
        public string? OrderBy { get; set; }
    }
}
