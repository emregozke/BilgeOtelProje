using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public  class WorkSchedule : BaseEntity
    {
        public DateTime Date { get; set; }
        public TimeSpan TotalWorkTime { get; set; }
        public TimeSpan TimesWorked { get; set; }
        public bool HaveOverTime { get; set; }
        public TimeSpan OverTimeHour { get; set; }
        public string Description { get; set; }
        public string ShiftName { get; set; }
        public TimeSpan ShiftStartTime { get; set; }
        public TimeSpan ShiftEndTime { get; set; }
        //
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
