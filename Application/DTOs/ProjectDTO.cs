using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? ProjectName { get; set; }

        public DateTime CreateAt { get; set; }

        public int Space_Id { get; set; }
    }
}
