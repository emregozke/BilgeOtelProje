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
    public class ServicePackService : IServicePackService
    {
        private readonly IRepository<ServicePack> servicePackRepository;

        public ServicePackService(IRepository<ServicePack>servicePackRepository)
        {
            this.servicePackRepository = servicePackRepository;
        }
        
        public void Create(ServicePack servicePack)
        {
            servicePackRepository.Create(servicePack);
        }

        public void Delete(ServicePack servicePack)
        {
            servicePackRepository.Delete(servicePack);
        }

        public ServicePack Get(int id)
        {
            return servicePackRepository.Get(id);
        }

        public IEnumerable<ServicePack> GetAll()
        {
            return servicePackRepository.GetAll().ToList();
        }

        public void Update(ServicePack servicePack)
        {
            servicePackRepository.Update(servicePack);
        }
    }
}
