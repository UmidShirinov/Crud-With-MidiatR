using ITS.POP.Domain.Dto;
using ITS.POP.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.POP.Infrastructure.Repositories.CompanyRepository
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Companies>> GetCompaniesAsync();
        Task<Companies> GetCompanyByIdAsync(int id);
        Task<Companies> GetCompanyByNameAsync(string name);
        Task<NoDataDto> DeleteCompanyByIdAsync(int id);
        Task<Companies> AddCompanyAsync(Companies Company);
        Task<Companies> UpdateCompanyAsync(Companies Company);



    }
}
