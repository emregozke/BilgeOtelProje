using Business.Repository.Abstract;
using Business.Service.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service.Concrete
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IRepository<Registration> registrationRepository;

        public RegistrationService(IRepository<Registration>registrationRepository)
        {
            this.registrationRepository = registrationRepository;
        }
        public void Create(Registration registration)
        {
            registrationRepository.Create(registration);
        }

        public void Delete(Registration registration)
        {
            registrationRepository.Delete(registration);
        }

        public Registration Get(int id)
        {
            return registrationRepository.Get(id);
        }

        public IEnumerable<Registration> GetAll()
        {
            return registrationRepository.GetAll().ToList();
        }

        public void Update(Registration registration)
        {
            registrationRepository.Update(registration);
        }
    }
}
