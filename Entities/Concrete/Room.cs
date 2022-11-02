using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Room : BaseEntity
    {
        public string RoomNumber { get; set; }
        public int FloorNumber { get; set; }
        public string Description { get; set; }
        //
        public int RoomTypeId  { get; set; }
        public virtual RoomType RoomType { get; set; }
        public List<Registration> Registrations { get; set; }
        public List<ReceptionReservation> ReceptionReservations { get; set; }
        public List<WebReservation> WebReservations { get; set; }
    }
}
