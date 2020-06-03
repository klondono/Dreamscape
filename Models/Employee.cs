using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace Dreamscape.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateHired { get; set; }

        public DateTime DOB { get; set; }
        public string Department { get; set; }
        public bool IsActive { get; set; }
        public DateTime TimeUpdated { get; set; }

        public int CreatedBy { get; set; }


    }
}
