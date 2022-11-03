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
    public class GuestRegistrationService : IGuestRegistrationService
    {
        private readonly IRepository<GuestRegistration> guestRegistrationRepository;

        public GuestRegistrationService(IRepository<GuestRegistration>guestRegistrationRepository)
        {
            this.guestRegistrationRepository = guestRegistrationRepository;
        }
        public void Create(GuestRegistration guestRegistration)
        {
            guestRegistrationRepository.Create(guestRegistration);
        }

        public void Delete(GuestRegistration guestRegistration)
        {
            guestRegistrationRepository.Delete(guestRegistration);
        }

        public GuestRegistration Get(int id)
        {
            return guestRegistrationRepository.Get(id);
        }

        public IEnumerable<GuestRegistration> GetAll()
        {
            return guestRegistrationRepository.GetAll().ToList();
        }

        public void Update(GuestRegistration guestRegistration)
        {
            guestRegistrationRepository.Update(guestRegistration);
        }
    }
}
