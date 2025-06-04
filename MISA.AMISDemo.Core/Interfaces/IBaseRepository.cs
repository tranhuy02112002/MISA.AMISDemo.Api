using MISA.AMISDemo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.AMISDemo.Core.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        List<T> GetAll();
        T Get(Guid id);
        int Insert(T entity);
        int Update(T entity);
        int Delete(T entity);
        int DeleteAll();

    }
}
