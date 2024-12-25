namespace Domain.Entities.Exceptions.Employees;

public class EmployeeNotFoundException : NotFoundException
{
    public EmployeeNotFoundException(Guid employeeId)
        : base($"Employee with id: {employeeId} doesn't exist in the database.")
    {
    }
}