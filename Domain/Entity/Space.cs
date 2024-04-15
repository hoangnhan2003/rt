using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Space
    {
        public int Id { get; set; }
        public string? SpaceName { get; set; }
        public DateTime CreateAt { get; set; }
        public List<Project>? Projects { get; set;}
        public List<Space_User>? Space_Users { get; set; }
        public bool IsActive { get; set; }
    }
}
