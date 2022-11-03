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
    public class GuestService : IGuestService
    {
        private readonly IRepository<Guest> guestRepository;

        public GuestService(IRepository<Guest>guestRepository)
        {
            this.guestRepository = guestRepository;
        }
        public void Create(Guest guest)
        {
            guestRepository.Create(guest);
        }

        public void Delete(Guest guest)
        {
            guestRepository.Delete(guest);
        }

        public Guest Get(int id)
        {
            return guestRepository.Get(id);
        }

        public IEnumerable<Guest> GetAll()
        {
            return guestRepository.GetAll().ToList();
        }

        public void Update(Guest guest)
        {
            guestRepository.Update(guest);
        }
    }
}
