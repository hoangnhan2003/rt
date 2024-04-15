using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Issue
    {
        public int Id { get; set; }

        public int Project_Id { get; set; }
        public Project? Project { get; set; }

        public int? IssueType_Id { get; set; }
        public Issue_Type? Issue_Types { get; set; }

        public int? Status_Id { get; set; }
        public Status? Statuses { get; set; }

        public int? Priority_Id { get; set; }
        public Priority? Priority { get; set; }  

        public int? Category_Id { get; set; }
        public Category? Categories { get; set; }

        public List<Comment>? Comment { get; set; }

        public DateTime? Due_Date { get; set; }
        public int? Asssignee { get; set; }
        public string? Content { get; set; }
        public string? Subject { get; set; }
        public byte? File { get; set; }
        public DateTime CreateAt { get; set; }
        public int UserCreate { get; set; }
        public bool IsActive { get; set; }
    }
}
