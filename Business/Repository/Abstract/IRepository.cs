

using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Repository.Abstract
{
    public interface IRepository<T> where T:BaseEntity
    {
        IEnumerable<T> GetAll();
        
        void Create(T entity);
       
        void Delete(T entity);
       
        void Update(T entity);
       
        T Get(int id);
        void SaveChanges();
    }
}
