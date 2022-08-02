using MachineGoDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities.Concrete
{
    public class Type : IEntity
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }
    }
}
