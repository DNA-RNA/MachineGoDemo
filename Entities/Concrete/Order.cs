﻿using MachineGoDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineGoDemo.Entities.Concrete
{
    public class Order : IEntity
    {
        public int OrderId { get; set; }

    }
}