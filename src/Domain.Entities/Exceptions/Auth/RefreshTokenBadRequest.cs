using Domain.Entities.Exceptions.Shared;

namespace Domain.Entities.Exceptions.Auth;

public sealed class RefreshTokenBadRequest : BadRequestException
{
    public RefreshTokenBadRequest()
        : base("Invalid client request. The tokenDto has some invalid values.")
    {
    }
}