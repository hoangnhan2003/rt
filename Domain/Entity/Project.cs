using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Project
    {
        public int Id { get; set; }

        public string? ProjectName { get; set; }

        public DateTime CreateAt { get; set; }

        public int Space_Id { get; set; }
        public Space? Space{ get; set; }

        public Git? Git { get; set; }

        public List<Wiki>? Wiki { get; set; }

        public List<Issue>? Issues { get; set; } 

        public List<Project_User>? ProjectUsers { get; set; }

        public List<History>? Histories { get; set; }

        public bool IsActive { get; set; }
    }
}
