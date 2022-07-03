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
        Task<IEnumerable<Company>> GetCompaniesAsync();
        Task<Company> GetCompanyByIdAsync(int id);
        Task<Company> GetCompanyByNameAsync(string name);
        Task<NoDataDto> DeleteCompanyByIdAsync(int id);
        Task<Company> AddCompanyAsync(Company Company);
        Task<Company> UpdateCompanyAsync(Company Company);



    }
}
