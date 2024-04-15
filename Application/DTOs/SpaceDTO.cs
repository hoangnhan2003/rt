using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class SpaceDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? SpaceName { get; set; }
        
        public DateTime CreateAt { get; set; }
    }
}
