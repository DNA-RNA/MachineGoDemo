using MachineGoDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities.Concrete
{
    public class MachineType : IEntity
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
    }
}
