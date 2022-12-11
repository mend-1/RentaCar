using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busines.Abstract
{
    public interface IEntityService<T> where T : class , IEntity ,new()
    {
        void Add(T entity); 
    }
}
