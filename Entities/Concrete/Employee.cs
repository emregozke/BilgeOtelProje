using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Employee : BaseEntity
    {
        public string Title { get; set; }
        public int IdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal MonthlySalary { get; set; }
        public decimal OvertimePay { get; set; }
        public DateTime StartDateOfWork { get; set; }
        public DateTime LeavingWorkDate { get; set; }

        //

        public int ShiftId { get; set; }
        public int DepartmantId { get; set; }
        public virtual Shift Shift { get; set; }

        public virtual Department Department { get; set; }
        public List<Salary> Salaries { get; set; }
        public List<WorkSchedule> WorkSchedules { get; set; }
    }
}
