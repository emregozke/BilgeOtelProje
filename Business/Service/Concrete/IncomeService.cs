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
    public class IncomeService : IIncomeService
    {
        private readonly IRepository<Income> incomeRepository;

        public IncomeService(IRepository<Income>incomeRepository)
        {
            this.incomeRepository = incomeRepository;
        }
        public void Create(Income income)
        {
            incomeRepository.Create(income);
        }

        public void Delete(Income income)
        {
            incomeRepository.Delete(income);
        }

        public Income Get(int id)
        {
            return incomeRepository.Get(id);
        }

        public IEnumerable<Income> GetAll()
        {
            return incomeRepository.GetAll().ToList();
        }

        public void Update(Income income)
        {
            incomeRepository.Update(income);
        }
    }
}
