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
    public class ExtraServiceService : IExtraServiceService
    {
        private readonly IRepository<ExtraService> extraServiceRepository;

        public ExtraServiceService(IRepository<ExtraService>extraServiceRepository)
        {
            this.extraServiceRepository = extraServiceRepository;
        }
        public void Create(ExtraService extraservice)
        {
            extraServiceRepository.Create(extraservice);
        }

        public void Delete(ExtraService extraservice)
        {
            extraServiceRepository.Delete(extraservice);
        }

        public ExtraService Get(int id)
        {
            return extraServiceRepository.Get(id);
        }

        public IEnumerable<ExtraService> GetAll()
        {
            return extraServiceRepository.GetAll().ToList();
        }

        public void Update(ExtraService extraservice)
        {
            extraServiceRepository.Update(extraservice);
        }
    }
}
