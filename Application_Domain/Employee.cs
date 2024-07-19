using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Domain
{
    public class Employee
    {

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string? Email { get; set; }
    }
}
