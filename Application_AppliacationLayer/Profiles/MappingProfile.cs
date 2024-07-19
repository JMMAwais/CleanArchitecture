using Application_AppliacationLayer.DTOs;
using Application_Domain;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_AppliacationLayer.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee,EmployeeDTO>().ForMember(dest => dest.FirstName, opt=> opt.MapFrom(src=> src.FirstName));
            CreateMap<EmployeeDTO,Employee>().ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName)).ForMember(dest => dest.EmployeeId, opt => opt.Ignore()); ;
        }
    }
}
