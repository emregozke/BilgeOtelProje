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
    public class ShiftService : IShiftService
    {
        private readonly IRepository<Shift> shiftRepository;

        public ShiftService(IRepository<Shift>shiftRepository)
        {
            this.shiftRepository = shiftRepository;
        }
        
        public void Create(Shift shift)
        {
            shiftRepository.Create(shift);
        }

        public void Delete(Shift shift)
        {
            shiftRepository.Delete(shift);
        }

        public Shift Get(int id)
        {
            return shiftRepository.Get(id);
        }

        public IEnumerable<Shift> GetAll()
        {
            return shiftRepository.GetAll().ToList();
        }

        public void Update(Shift shift)
        {
            shiftRepository.Update(shift);
        }
    }
}
