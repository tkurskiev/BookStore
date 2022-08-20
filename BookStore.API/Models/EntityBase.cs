using System.ComponentModel.DataAnnotations;

namespace BookStore.API.Models
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
    }
}
