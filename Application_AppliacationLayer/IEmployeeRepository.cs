using Application_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_AppliacationLayer
{
    public interface IEmployeeRepository
    {
         List<Application_Domain.Employee> GetAllEmployees();
         void AddEmployee(Application_Domain.Employee employee);
         Employee UpdateEmployee(Application_Domain.Employee employee);
         Employee GetEmployeeById(int Id);
         void DeleteEmployee(Employee employee);
         
        

    }
}
