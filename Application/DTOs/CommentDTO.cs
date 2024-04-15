using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class CommentDTO
    {
        public int Id { get; set; }

        public int Issue_Id { get; set; }

        public int User_Id { get; set; }

        [Required]
        public string? Content { get; set; }
    }
}
