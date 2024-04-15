using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Project_User
    {
        public int Id { get; set; }

        public int Project_Id { get; set; }
        public Project? Project { get; set; }

        public int MemberRoleId { get; set; }
        public Member_Role? Member_Roles { get; set; }    

        public int User_Id { get; set; }
        public User? Users { get; set; }  
    }
}
