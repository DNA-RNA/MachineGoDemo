using MachineGoDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineGoDemo.Entities.Concrete
{
    public class Company : IEntity
    {
        public int CompanyId { get; set; }
        public string? CompanyName { get; set; }
    }
}
