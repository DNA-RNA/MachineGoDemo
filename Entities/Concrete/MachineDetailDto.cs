using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MachineDetailDto : IDto
    {
        public int MachineId { get; set; }
        public string CategoryName { get; set; }
        public string  BrandName { get; set; }
        public string  TypeName { get; set; }
        public string Model { get; set; }
        public short ModelYear { get; set; }

    }
}
