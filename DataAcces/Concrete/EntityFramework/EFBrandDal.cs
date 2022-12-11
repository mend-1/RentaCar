using Core.DataAccess.EntityFramework;
using DataAcces.Abstract;
using DataAcces.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFBrandDal : EfEntityRepositoryBase<Brand, CarRentalContext> , IBrandDal
    {
       
    }
}
