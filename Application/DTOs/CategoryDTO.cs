using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? CategoryName { get; set; }
    }
}
