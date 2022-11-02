using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Salary : BaseEntity
    {
        public decimal MonthlySalary { get; set; }
        public bool BeenPaid { get; set; }
        public string Description { get; set; }
        public DateTime? PaymentDate { get; set; }

        //

        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }


    }
}
