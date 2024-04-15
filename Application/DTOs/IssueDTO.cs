using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class IssueDTO
    {
        public int Id { get; set; }

        public int Project_Id { get; set; }

        public int? IssueType_Id { get; set; }

        public int? Status_Id { get; set; }

        public int? Priority_Id { get; set; }

        public int? Category_Id { get; set; }

        public DateTime? Due_Date { get; set; }

        public int? Asssignee { get; set; }

        [Required]
        public string? Content { get; set; }

        [Required]
        [MaxLength(500)]
        public string? Subject { get; set; }

        public byte? File { get; set; }

        public DateTime CreateAt { get; set; }

        public int UserCreate { get; set; }
    }
}
