﻿using ProjectTemplate.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace ProjectTemplate.Core.Entities
{
    public class User:IEntityKey<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Role? Role { get; set; }
    }
}
