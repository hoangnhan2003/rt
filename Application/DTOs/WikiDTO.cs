using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class WikiDTO
    {
        public int Id { get; set; }

        public int Project_Id { get; set; }

        [Required]
        public string? Content { get; set; } 
    }
}
