using Microsoft.AspNetCore.Http;
using Shared.Shared.RequestFeatures;

namespace Domain.Entities.LinkModels;

public record LinkParameters(EmployeeParameters EmployeeParameters, HttpContext Context);
