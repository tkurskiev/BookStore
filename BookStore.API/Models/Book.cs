using System.ComponentModel.DataAnnotations;

namespace BookStore.API.Models
{
    public class Book : EntityBase
    {
        [Required]
        [MaxLength(256)]
        public string? Author { get; set; }

        [Required]
        [MaxLength(256)]
        public string? Title { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }
    }
}
