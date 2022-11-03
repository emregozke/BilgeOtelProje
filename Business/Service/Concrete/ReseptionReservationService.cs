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
    public class ReseptionReservationService : IReseptionReservationService
    {
        private readonly IRepository<ReceptionReservation> reseptionReservationRepository;

        public ReseptionReservationService(IRepository<ReceptionReservation> reseptionReservationRepository)
        {
            this.reseptionReservationRepository = reseptionReservationRepository;
        }
        public void Create(ReceptionReservation receptionReservation)
        {
            reseptionReservationRepository.Create(receptionReservation);
        }

        public void Delete(ReceptionReservation receptionReservation)
        {
            reseptionReservationRepository.Delete(receptionReservation);
        }

        public ReceptionReservation Get(int id)
        {
            return reseptionReservationRepository.Get(id);
        }

        public IEnumerable<ReceptionReservation> GetAll()
        {
            return reseptionReservationRepository.GetAll().ToList();
        }

        public void Update(ReceptionReservation receptionReservation)
        {
            reseptionReservationRepository.Update(receptionReservation);
        }
    }
}
