using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Registration : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public TimeSpan CheckInTime { get; set; }
        public TimeSpan? CheckOutTime { get; set; }

        //

        public int RoomId { get; set; }
        public int ServicePackId { get; set; }
        public virtual ServicePack ServicePack { get; set; }
        public virtual Room Room { get; set; }
        public List<Income> Incomes { get; set; }
        public List<GuestRegistration> GuestRegistrations { get; set; }
        public List<UseOfExtraService> UseOfExtraServices { get; set; }
    }
}
