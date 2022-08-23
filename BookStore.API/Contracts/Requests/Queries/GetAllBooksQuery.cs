using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Contracts.Requests.Queries
{
    public class GetAllBooksQuery
    {
        [FromQuery(Name = "title")]
        public string? Title { get; set; }

        [FromQuery(Name = "author")]
        public string? Author { get; set; }

        // TODO: Format Checking yyyy-MM-dd
        [FromQuery(Name = "publicationDate")]
        public DateTime? PublicationDate { get; set; }

        // TODO: usage of this property for filtering too...
        [FromQuery(Name = "orderBy")]
        public string? OrderBy { get; set; }
    }
}
