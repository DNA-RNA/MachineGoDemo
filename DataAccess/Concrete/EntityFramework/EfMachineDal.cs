using DataAccess.Abstract;
using Entities.Concrete;
using MachineGoDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMachineDal : EfEntityRepositoryBase<Machine, MachinGoContext>, IMachineDal
    {
        public List<MachineDetailDto> GetMachineDetails()
        {
            using (MachinGoContext context = new MachinGoContext())
            {
                var result = from p in context.machines
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             join b in context.Brands 
                             on p.BrandId equals b.BrandId
                             join t in context.MachineTypes
                             on p.TypeId equals t.TypeId
                         
                             select new MachineDetailDto
                             {
                                 MachineId = p.MachineId,
                                 CategoryName  = c.CategoryName,
                                 BrandName = b.BrandName,
                                 TypeName = t.TypeName,
                                 Model = p.Model,
                                 ModelYear = p.ModelYear
                             };

                return result.ToList();
            }
        }
    }
}
