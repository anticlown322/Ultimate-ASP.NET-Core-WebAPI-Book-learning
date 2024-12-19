using Domain.Entities.Exceptions.Shared;

namespace Domain.Entities.Exceptions;

public sealed class IdParametersBadRequestException : BadRequestException
{
    public IdParametersBadRequestException()
        :base("Parameter ids is null")
    {
    }
}
