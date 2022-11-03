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
    public class UseOfExtraServiceService : IUseOfExtraServiceService
    {
        private readonly IRepository<UseOfExtraService> useOfExtraServiceRepository;

        public UseOfExtraServiceService(IRepository<UseOfExtraService>useOfExtraServiceRepository)
        {
            this.useOfExtraServiceRepository = useOfExtraServiceRepository;
        }
        
        public void Create(UseOfExtraService useOfExtraService)
        {
            useOfExtraServiceRepository.Create(useOfExtraService);
        }

        public void Delete(UseOfExtraService useOfExtraService)
        {
            useOfExtraServiceRepository.Delete(useOfExtraService);
        }

        public UseOfExtraService Get(int id)
        {
            return useOfExtraServiceRepository.Get(id);
        }

        public IEnumerable<UseOfExtraService> GetAll()
        {
            return useOfExtraServiceRepository.GetAll().ToList();
        }

        public void Update(UseOfExtraService useOfExtraService)
        {
            useOfExtraServiceRepository.Update(useOfExtraService);
        }
    }
}
