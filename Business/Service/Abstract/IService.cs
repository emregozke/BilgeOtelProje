using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service.Abstract
{
    public interface IService<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();

        void Create(T entity);

        void Delete(T entity);

        void Update(T entity);

        T Get(int id);
    }
}
