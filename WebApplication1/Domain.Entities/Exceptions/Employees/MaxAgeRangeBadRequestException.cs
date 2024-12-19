using Domain.Entities.Exceptions.Shared;

namespace Domain.Entities.Exceptions.Employees;

public sealed class MaxAgeRangeBadRequestException : BadRequestException
{
    public MaxAgeRangeBadRequestException()
        :base("Max age can't be less than min age.")
    { }
}
