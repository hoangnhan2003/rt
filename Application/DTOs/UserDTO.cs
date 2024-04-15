using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class UserDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? FullName { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required, Compare(nameof(Password))]
        public string? ConfirmPassword { get; set; }

        [Required, EmailAddress]
        public string? Email { get; set; }

        public byte Avatar { get; set; }
    }
}
