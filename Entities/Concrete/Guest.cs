using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Guest  :BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentificationNumber { get; set; }
        public string Adress { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        //
        public List<GuestRegistration> GuestRegistrations { get; set; }
    }
}
