using Domain.Entities.Exceptions.Shared;

namespace Domain.Entities.Exceptions.Companies;

public sealed class CompanyCollectionBadRequest : BadRequestException
{
    public CompanyCollectionBadRequest()
        :base("Company collection sent from a client is null.")
    {
    }
}