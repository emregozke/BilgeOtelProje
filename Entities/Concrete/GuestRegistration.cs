using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class GuestRegistration : BaseEntity
    {
        public int GuestId { get; set; }
        public int RegistrationId { get; set; }
        public virtual Registration Registration { get; set; }
        public virtual Guest Guest { get; set; }
    }
}
