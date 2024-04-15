﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Git
    {
        public int Id { get; set; }
        public int Project_Id { get; set; }
        public Project? Project { get; set; }
        public List<Git_Repo>? Git_Repos { get; set; }
    }
}