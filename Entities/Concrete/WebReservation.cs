using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class WebReservation : BaseEntity
    {
        public bool Payment { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal Price { get; set; }

        //

        public int RoomId { get; set; }
        public int? RoomTypeId { get; set; }
        public int ServicePackId { get; set; }
        public virtual ServicePack ServicePack { get; set; }

        public virtual RoomType RoomType { get; set; }
        public virtual Room Room { get; set; }
    }
}
