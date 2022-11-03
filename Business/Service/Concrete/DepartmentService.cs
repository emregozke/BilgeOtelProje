using Business.Repository.Abstract;
using Business.Service.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service.Concrete
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IRepository<Department> departmentRepository;

        public DepartmentService(IRepository<Department> departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }

        public void Create(Department department)
        {
            departmentRepository.Create(department);
        }

        public void Delete(Department department)
        {
            departmentRepository.Delete(department);
        }

        public Department Get(int id)
        {
            return departmentRepository.Get(id);
        }

        public IEnumerable<Department> GetAll()
        {
            return departmentRepository.GetAll().ToList();
        }

        public void Update(Department department)
        {
            departmentRepository.Update(department);
        }
    }
}
