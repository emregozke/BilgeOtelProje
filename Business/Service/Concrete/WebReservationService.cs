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
    public class WebReservationService : IWebReservationService
    {
        private readonly IRepository<WebReservation> webReservationRepository;

        public WebReservationService(IRepository<WebReservation>webReservationRepository)
        {
            this.webReservationRepository = webReservationRepository;
        }
        
        public void Create(WebReservation webReservation)
        {
            webReservationRepository.Create(webReservation);
        }

        public void Delete(WebReservation webReservation)
        {
            webReservationRepository.Delete(webReservation);
        }

        public WebReservation Get(int id)
        {
            return webReservationRepository.Get(id);
        }

        public IEnumerable<WebReservation> GetAll()
        {
            return webReservationRepository.GetAll().ToList();
        }

        public void Update(WebReservation webReservation)
        {
            webReservationRepository.Update(webReservation);
        }
    }
}
