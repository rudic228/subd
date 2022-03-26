﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDB.Tables
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("RoleId")]
        public virtual List<User> Users { get; set; }

    }
}
