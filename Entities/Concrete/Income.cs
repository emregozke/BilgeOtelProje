using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Income  : BaseEntity
    {
        public DateTime IncomeDate { get; set; }
        public decimal TotalPrice { get; set; }

        //
        public int RegistrationId { get; set; }
        public virtual Registration Registration { get; set; }

    }
}
