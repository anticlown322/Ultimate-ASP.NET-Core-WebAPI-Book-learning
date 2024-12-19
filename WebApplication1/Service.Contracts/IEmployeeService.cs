using System.Dynamic;
using Domain.Entities.LinkModels;
using Domain.Entities.Models;
using Shared.Shared.DataTransferObjects;
using Shared.Shared.DataTransferObjects.Employee;
using Shared.Shared.RequestFeatures;

namespace Service.Contracts;

public interface IEmployeeService
{
    Task<(LinkResponse linkResponse, MetaData metaData)> GetEmployeesAsync(Guid companyId,
        LinkParameters linkParameters, bool trackChanges);
    
    Task<EmployeeDto> GetEmployeeAsync(Guid companyId, Guid id, bool trackChanges);
    
    Task<EmployeeDto> CreateEmployeeForCompanyAsync(Guid companyId, EmployeeForCreationDto employeeForCreation, bool trackChanges);
    
    Task DeleteEmployeeForCompanyAsync(Guid companyId, Guid id, bool trackChanges);
    
    Task UpdateEmployeeForCompanyAsync(Guid companyId, Guid id, 
        EmployeeForUpdateDto employeeForUpdate, bool compTrackChanges, bool empTrackChanges);
    
    Task<(EmployeeForUpdateDto employeeToPatch, Employee employeeEntity)> GetEmployeeForPatchAsync
    (Guid companyId, Guid id, bool compTrackChanges, bool empTrackChanges);
    
    Task SaveChangesForPatchAsync(EmployeeForUpdateDto employeeToPatch, Employee employeeEntity);
}