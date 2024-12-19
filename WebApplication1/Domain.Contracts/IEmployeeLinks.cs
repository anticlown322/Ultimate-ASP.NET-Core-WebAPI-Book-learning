using Domain.Entities.LinkModels;
using Microsoft.AspNetCore.Http;
using Shared.Shared.DataTransferObjects.Employee;

namespace Domain.Contracts;

public interface IEmployeeLinks
{
    LinkResponse TryGenerateLinks(IEnumerable<EmployeeDto> employeesDto,
        string fields, Guid companyId, HttpContext httpContext);
}
