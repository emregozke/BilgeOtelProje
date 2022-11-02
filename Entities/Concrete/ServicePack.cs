using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ServicePack : BaseEntity
    {
        public string PackName { get; set; }
        public decimal PackPrice { get; set; }
        public string Description { get; set; }
        //
        public List<ReceptionReservation> ReceptionReservations { get; set; }
        public List<Registration> Registrations { get; set; }
        public List<WebReservation> WebReservations { get; set; }
    }
}
