using Application_AppliacationLayer;
using Application_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture_Infrastructure.Data;

namespace CleanArchitecture_Infrastructure
{
    public class EmployoeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _db;

        public EmployoeeRepository(EmployeeDbContext db)
        {
                _db= db;
        }

        public void AddEmployee(Employee employee)
        {
            _db.Employees.Add(employee);
            _db.SaveChanges();
        }

        public List<Employee> GetAllEmployees()
        {
            return _db.Employees.ToList();  
        }

        public Employee GetEmployeeById(int Id)
        {
          return _db.Employees.FirstOrDefault(x => x.EmployeeId == Id);
        }

        public Employee UpdateEmployee(Employee employee)
        {
            _db.Employees.Update(employee);
            _db.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            _db.Employees.Remove(employee);
            _db.SaveChanges();
        }
    }
}
