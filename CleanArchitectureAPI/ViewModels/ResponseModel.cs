using Application_AppliacationLayer.DTOs;

namespace CleanArchitectureAPI.ViewModels
{
    public class ResponseModel
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public List<EmployeeDTO> Employee { get; set; }
    }
}
