﻿using MachineGoDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineGoDemo.Entities.Concrete
{
    public class User : IEntity
    {
        public int UserId { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

    }
}
