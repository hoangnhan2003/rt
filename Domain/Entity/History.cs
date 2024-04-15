using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class History
    {
        public int Id { get; set; }

        public int User_Id { get; set; }
        public User? User { get; set; }

        public int Active_Id { get; set; }
        public int ActiveTypeId { get; set; }
        public Active_Type? Active_Types { get; set; }

        public DateTime CreateAt { get; set; }

        public string? Message { get; set; }

        public int Project_Id { get; set; }
        public Project? Project { get; set; }
    }
}
