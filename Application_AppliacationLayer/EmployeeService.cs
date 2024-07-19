using Application_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_AppliacationLayer
{
    public class EmployeeService : IEmployeeServices
    {

        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository )
        {
                _employeeRepository = employeeRepository;
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAllEmployees();
        }

        public void AddEmployee(Application_Domain.Employee employee)
        {
            _employeeRepository.AddEmployee(employee);
        }

        public Employee UpdateEmployee(Employee employee)
        {
          return  _employeeRepository.UpdateEmployee(employee);
            
        }

        public Employee GetEmployeeById(int Id)
        {
          return  _employeeRepository.GetEmployeeById(Id);
        }

        public void DeleteEmployee(Employee employee)
        {
            _employeeRepository.DeleteEmployee(employee); 
        }
    }
}
