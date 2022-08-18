using System.ComponentModel.DataAnnotations;

namespace BookStore.API.Models
{
    public abstract class EntityBase
    {
        [Required]
        public int Id { get; set; }
    }
}
