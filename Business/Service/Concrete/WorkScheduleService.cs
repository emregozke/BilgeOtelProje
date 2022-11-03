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
    public class WorkScheduleService : IWorkScheduleService
    {
        private readonly IRepository<WorkSchedule> workScheduleRepository;

        public WorkScheduleService(IRepository<WorkSchedule>workScheduleRepository)
        {
            this.workScheduleRepository = workScheduleRepository;
        }
        
        public void Create(WorkSchedule workSchedule)
        {
            workScheduleRepository.Create(workSchedule);
        }

        public void Delete(WorkSchedule workSchedule)
        {
            workScheduleRepository.Delete(workSchedule);
        }

        public WorkSchedule Get(int id)
        {
            return workScheduleRepository.Get(id);
        }

        public IEnumerable<WorkSchedule> GetAll()
        {
            return workScheduleRepository.GetAll().ToList();
        }

        public void Update(WorkSchedule workSchedule)
        {
            workScheduleRepository.Update(workSchedule);
        }
    }
}
