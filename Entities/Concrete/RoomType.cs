using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class RoomType : BaseEntity
    {
        public string RoomTypeName { get; set; }
        public string Description { get; set; }
        public int NumberOfPeople { get; set; }
        public int NumberOfBed { get; set; }
        public decimal Price { get; set; }

        //

        public List<ReceptionReservation> ReceptionReservations { get; set; }
        public List<RoomPicture> RoomPictures { get; set; }
        public List<Room> Rooms { get; set; }
        public List<WebReservation> WebReservations { get; set; }

    }
}
