namespace BookStore.API.Models
{
    public class GetAllBooksFilter
    {
        public string? Title { get; set; }

        public string? Author { get; set; }

        public DateTime? PublicationDate { get; set; }
        
        public string? OrderBy { get; set; }
    }
}
