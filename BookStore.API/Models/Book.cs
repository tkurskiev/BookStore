namespace BookStore.API.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Author { get; set; } = null!;
        public string Title { get; set; } = null!;
        public DateTime PublicationDate { get; set; }
    }
}
