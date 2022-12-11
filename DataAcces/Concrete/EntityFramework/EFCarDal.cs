using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAcces.Abstract;
using Entities.Concrete;
using DataAcces.Concrete.EntityFramework;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDAL : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public void Add(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
