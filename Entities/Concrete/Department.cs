using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Department : BaseEntity
    {
        public string DepartmentName { get; set; }
        public string Description { get; set; }

        //

        public List<Employee> Employees { get; set; }



    }
}
