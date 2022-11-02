using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ExtraService  :BaseEntity
    {
        public string ServiceName { get; set; }
        public decimal Price { get; set; }

        //
        public List<UseOfExtraService> UseOfExtraServices { get; set; }
    }
}
