using ITS.POP.Domain.Model;
using MediatR;

namespace ITS.POP.Api.Application.Queries.Company.GetCompanies
{
    public class GetCompanyQuery:IRequest<List<Companies>>
    {
    }
}
