using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public byte Avatar { get; set; }
        public List<Project_User>? Project_Users { get; set; }
        public List<Space_User>? Space_Users { get; set; }
        public bool IsActive { get; set; }
    }
}
