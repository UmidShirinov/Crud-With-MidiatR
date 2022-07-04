using ITS.POP.Domain.Model;
using ITS.POP.Infrastructure.Repositories.CompanyRepository;
using MediatR;

namespace ITS.POP.Api.Application.Queries.Company.GetCompanies
{
    public class GetCompanyHandler : IRequestHandler<GetCompanyQuery, List<Companies>>
    {

        private readonly ICompanyRepository _companyRepository;
        public GetCompanyHandler(ICompanyRepository _companyRepository)
        {
            this._companyRepository = _companyRepository;
        }

        public async Task<List<Companies>> Handle(GetCompanyQuery request, CancellationToken cancellationToken)
        {
            var orders = await _companyRepository.GetCompaniesAsync();
            return orders.ToList();
        }
    }
}
