namespace BookStore.API.Contracts.Responses
{
    public class BookResponse
    {
        public BookResponse()
        {
        }

        public int Id { get; set; }
        public string? Author { get; set; }
        public string? Title { get; set; }
        public DateTime PublicationDate { get; set; }
    }
}
