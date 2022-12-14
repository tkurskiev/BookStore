namespace BookStore.API.Models
{
    public class Book : EntityBase
    {
        public string? Author { get; set; }

        public string? Title { get; set; }

        public DateTime PublicationDate { get; set; }
    }
}
