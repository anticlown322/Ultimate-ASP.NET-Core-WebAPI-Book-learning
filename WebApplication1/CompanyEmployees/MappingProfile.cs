using AutoMapper;
using Domain.Entities.Models;
using Shared.Shared.DataTransferObjects;
using Shared.Shared.DataTransferObjects.Company;
using Shared.Shared.DataTransferObjects.Employee;
using Shared.Shared.DataTransferObjects.User;

namespace CompanyEmployees;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Company, CompanyDto>()
            .ForMember(c => c.FullAddress, 
                opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));
        
        CreateMap<Employee, EmployeeDto>();
        
        CreateMap<CompanyForCreationDto, Company>();
        
        CreateMap<EmployeeForCreationDto, Employee>();

        CreateMap<EmployeeForUpdateDto, Employee>().ReverseMap();
        
        CreateMap<CompanyForUpdateDto, Company>();
        
        CreateMap<UserForRegistrationDto, User>();
    }
}