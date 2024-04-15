using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Comment
    {
        public int Id { get; set; }

        public int Issue_Id { get; set; }
        public Issue? Issue { get; set; }

        public int User_Id { get; set; }
        public User? User { get; set; }

        public string? CommentContent { get; set; }
    }
}
