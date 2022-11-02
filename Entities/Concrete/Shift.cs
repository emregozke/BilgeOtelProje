using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Shift : BaseEntity
    {
        public string ShiftName { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Description { get; set; }

        //

        public List<Employee> Employees { get; set; }

    }
}
