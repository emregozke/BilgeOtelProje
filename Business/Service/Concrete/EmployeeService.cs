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
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee> employeeRepository;

        public EmployeeService(IRepository<Employee>employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public void Create(Employee employee)
        {
            employeeRepository.Create(employee);
        }

        public void Delete(Employee employee)
        {
            employeeRepository.Delete(employee);
        }

        public Employee Get(int id)
        {
            return employeeRepository.Get(id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return employeeRepository.GetAll().ToList();
        }

        public void Update(Employee employee)
        {
            employeeRepository.Update(employee);
        }
    }
}
