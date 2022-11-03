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
    public class SalaryService : ISalaryService
    {
        private readonly IRepository<Salary> salaryRepository;

        public SalaryService(IRepository<Salary>salaryRepository)
        {
            this.salaryRepository = salaryRepository;
        }
        
        public void Create(Salary salary)
        {
            salaryRepository.Create(salary);
        }

        public void Delete(Salary salary)
        {
            salaryRepository.Delete(salary);
        }

        public Salary Get(int id)
        {
            return salaryRepository.Get(id);
        }

        public IEnumerable<Salary> GetAll()
        {
            return salaryRepository.GetAll().ToList();
        }

        public void Update(Salary salary)
        {
            salaryRepository.Update(salary);
        }
    }
}
