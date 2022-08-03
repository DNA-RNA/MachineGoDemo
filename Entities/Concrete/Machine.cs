using MachineGoDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineGoDemo.Entities.Concrete
{
    public class Machine : IEntity
    {
        public int MachineId { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int TypeId { get; set; }
        public int CompanyId { get; set; }
        public string Model { get; set; }
        public short ModelYear { get; set; }



    }
}
