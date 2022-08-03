using DataAccess.Abstract;
using Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMachineType : EfEntityRepositoryBase<MachineType, MachinGoContext>, IMachineTypeDal
    {
    }
}
