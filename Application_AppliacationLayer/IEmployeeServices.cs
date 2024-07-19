
using Application_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_AppliacationLayer
{
    public interface IEmployeeServices
    {
        List<Application_Domain.Employee> GetAllEmployees();
        public void AddEmployee(Application_Domain.Employee employee);
        Application_Domain.Employee UpdateEmployee(Application_Domain.Employee employee);
        Employee GetEmployeeById(int Id);
        void DeleteEmployee(Employee empl);
    }
}
