using Application_AppliacationLayer;
using Application_AppliacationLayer.DTOs;
using Application_Domain;
using AutoMapper;
using CleanArchitectureAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArchitectureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices _employeeServices;
        private readonly IMapper _mapper;
        public EmployeeController(IEmployeeServices employeeServices, IMapper mapper)
        {
             _employeeServices = employeeServices;
            _mapper = mapper;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public ActionResult<IList< Application_AppliacationLayer.DTOs.EmployeeDTO>> GetEmployees()
        {
            ResponseModel responseModel = new ResponseModel();
            var list= _employeeServices.GetAllEmployees();
            List<EmployeeDTO> employees = _mapper.Map<List<EmployeeDTO>>(list);
            return Ok(employees);
        }



        [HttpPost("AddEmployee")]   
        public ActionResult<EmployeeDTO> AddEmployee(EmployeeDTO employeeDTO)
        {
            if (employeeDTO !=null && employeeDTO.EmployeeId == 0)
            {
                Employee emp = _mapper.Map<Employee>(employeeDTO);
                emp.LastName = "khan";
                emp.PhoneNumber = "000000";
                _employeeServices.AddEmployee(emp);
                return Ok(employeeDTO);
            }
            return employeeDTO;
        }



        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public EmployeeDTO GetEmployeeById(int id)
        {
          var emp=  _employeeServices.GetEmployeeById(id);
          var empDTO= _mapper.Map<EmployeeDTO>(emp);
            return empDTO;
        }




        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public EmployeeDTO Put(int id, [FromBody] EmployeeDTO value)
        {
            var emp = _employeeServices.GetEmployeeById(id);
            emp.FirstName= value.FirstName;
            emp.DateofBirth= value.DateofBirth;
            emp.Email= value.Email;

            var employee=_mapper.Map<Employee>(emp);
            _employeeServices.UpdateEmployee(employee);
            return value;
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var employee= _employeeServices.GetEmployeeById(id);
            var removedemployee= _mapper.Map<Employee>(employee);
            _employeeServices.DeleteEmployee(removedemployee);
        }
    }
}
