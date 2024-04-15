using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Git_Repo
    {
        public int Id { get; set; }
        public int Git_Id { get; set; }
        public Git? Git { get; set; }

        public string? GitRepoUrl { get; set; }
    }
}
