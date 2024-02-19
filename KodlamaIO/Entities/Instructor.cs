﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Entities
{
    public class Instructor:BaseEntity
    {
        public string Surname { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
