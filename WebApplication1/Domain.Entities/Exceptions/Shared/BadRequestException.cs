namespace Domain.Entities.Exceptions.Shared;

public abstract class BadRequestException : Exception
{
    protected BadRequestException(string message)
        :base(message)
    {
    }
}