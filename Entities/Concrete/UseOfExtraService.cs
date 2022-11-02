using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class UseOfExtraService : BaseEntity
    {
        public int Quantity { get; set; }

        //
        public int ExtraServiceId { get; set; }
        public int RegistrationId { get; set; }
        public virtual ExtraService ExtraService { get; set; }
        public virtual Registration Registration { get; set; }


    }
}
