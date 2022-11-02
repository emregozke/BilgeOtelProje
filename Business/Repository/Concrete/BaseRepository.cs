using Business.Repository.Abstract;
using DataAccess.Context;
using Entities.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.Concrete
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private ProjectContext _context;
        private DbSet<T> _entities;
        public BaseRepository(ProjectContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public T Get(int id)
        {
            return _entities.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }

        public void Create(T entity)
        {
            if (entity != null)
            {
                _entities.Add(entity);
                SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            if (entity != null)
            {
                entity.Status = Entities.Enum.DataStatus.Deleted;
                SaveChanges();
            }

        }


        public void Update(T entity)
        {

            if (entity != null)
            {
                entity.Status = Entities.Enum.DataStatus.Modified;

                _context.Entry(entity).State = EntityState.Modified;
                SaveChanges();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}

